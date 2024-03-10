using Domain.Entities;
using Helpers;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking.Forms.Apartment
{
    public partial class ApartmentListForm : Form
    {
        //Номер поверха по якому ми відображаємо кімнати
        public int FloorId { get; set; }
        public ApartmentListForm()
        {
            InitializeComponent();

            lvImages.LargeImageList = new ImageList();
            lvImages.LargeImageList.ImageSize = new Size(180, 130);
            // lvImages.LargeImageList.
            lvImages.MultiSelect = false;
            lvImages.ListViewItemSorter = new ListViewIndexComparer();
            lvImages.InsertionMark.Color = Color.Green;
            lvImages.AllowDrop = true;

            LoadListApartments();
        }

        private void LoadListApartments(Func<ApartmentEntity, bool> condition = null)
        {
            lvImages.Clear();
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var list = context.Apartments.Include(x => x.ApartmentImages)
                    .Where(condition == null ? a => true : condition)
                    .ToList();
                foreach (var apartment in list)
                {
                    var dir = Path.Combine(Directory.GetCurrentDirectory(), "images", "apartments");
                    var first = apartment.ApartmentImages.FirstOrDefault();
                    if (first != null)
                    {
                        var imgName = first.Name;
                        var imagePath = Path.Combine(dir, "600_" + imgName);
                        string key = Guid.NewGuid().ToString();
                        ListViewItem item = new ListViewItem();
                        item.Tag = apartment.Id;
                        item.Text = apartment.Number;
                        item.ImageKey = key;
                        lvImages.LargeImageList.Images.Add(key,
                            Image.FromStream(ImageWorker.GetFileStream(imagePath)));
                        lvImages.Items.Add(item);
                    }
                }

            }
        }

        private void btnCreateApartment_Click(object sender, EventArgs e)
        {
            ApartmentCreateForm apartmentCreateForm = new ApartmentCreateForm();
            apartmentCreateForm.FloorId = FloorId;
            if (apartmentCreateForm.ShowDialog() == DialogResult.OK)
            {
                LoadListApartments();
            }
        }

        private void ApartmentListForm_Load(object sender, EventArgs e)
        {
            LoadListApartments();
        }

        private void lvImages_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void lvImages_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = lvImages.SelectedItems.Count > 0 ? lvImages.SelectedItems[0] : null;
            if (item != null)
            {
                ChangeApartmentInfoForm dlg = new ChangeApartmentInfoForm();
                dlg.Id = (int)item.Tag;
                dlg.ShowDialog();
                LoadListApartments();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFindByPrice_Click(object sender, EventArgs e)
        {
            LoadListApartments(a => a.PricePerNight == Convert.ToInt32(txtPrice.Text));
        }

        private void btnFindByBeds_Click(object sender, EventArgs e)
        {
            LoadListApartments(a => a.NumberOfBeds == Convert.ToInt32(txtNumberOfBeds.Text));
        }

        private void btnFindByRooms_Click(object sender, EventArgs e)
        {
            LoadListApartments(a => a.NumberOfRooms == Convert.ToInt32(txtNumberOfRooms.Text));
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            LoadListApartments();
        }
    }
}
