﻿using Domain.Entities;
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
    public partial class ChangeApartmentInfoForm : Form
    {
        public int Id;
        public ChangeApartmentInfoForm()
        {
            InitializeComponent();

            lvImages.LargeImageList = new ImageList();
            lvImages.LargeImageList.ImageSize = new Size(180, 130);
            // lvImages.LargeImageList.
            lvImages.MultiSelect = false;
            lvImages.ListViewItemSorter = new ListViewIndexComparer();
            lvImages.InsertionMark.Color = Color.Green;
            lvImages.AllowDrop = true;
        }

        private void btnSelectImages_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.bmp, *.webp)|*.jpg;*.jpeg;*.png;*.bmp;*.webp|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string file in openFileDialog.FileNames)
                    {
                        string imagePath = file;
                        string key = Guid.NewGuid().ToString();
                        ListViewItem item = new ListViewItem();
                        item.Tag = imagePath;
                        item.Text = Path.GetFileName(imagePath);
                        item.ImageKey = key;
                        lvImages.LargeImageList.Images.Add(key,
                            Image.FromStream(ImageWorker.GetFileStream(imagePath)));
                        lvImages.Items.Add(item);
                    }

                }
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            ApartmentEntity apartment = new ApartmentEntity();
            apartment.Number = txtNumber.Text;
            apartment.NumberOfRooms = Convert.ToInt32(txtNumberOfRooms.Text);
            apartment.NumberOfBeds = Convert.ToInt32(txtNumberOfBeds.Text);
            apartment.PricePerNight = Convert.ToDecimal(txtPricePerNight.Text);
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                context.Apartments.Where(a => a.Id == Id).ExecuteUpdate(
                    a => a.SetProperty(a => a.Number, txtNumber.Text)
                    .SetProperty(a => a.NumberOfRooms, Convert.ToInt32(txtNumberOfRooms.Text))
                    .SetProperty(a => a.NumberOfBeds, Convert.ToInt32(txtNumberOfBeds.Text))
                    .SetProperty(a => a.PricePerNight, Convert.ToDecimal(txtPricePerNight.Text)));
                short p = 1;
                context.ApartmentImages.Where(i => i.ApartmentId == Id).ExecuteDelete();
                foreach (ListViewItem item in lvImages.Items)
                {
                    string path = (string)item.Tag;
                    var imageName = ImageWorker.ImageSaveFile(path, "apartments");
                    var image = new ApartmentImageEntity
                    {
                        ApartmentId = Id,
                        Name = imageName,
                        Priority = p,
                    };
                    context.ApartmentImages.Add(image);
                    context.SaveChanges();
                    p++;
                }
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
