using Domain.Entities;
using Helpers;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking.Forms.Category
{
    public partial class CategoryCreationForm : Form
    {
        public CategoryCreationForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            using(ApplicationDbContext context = new ApplicationDbContext())
            {
                CategoryEntity category = new CategoryEntity();
                if(txtParentName.Text != string.Empty)category.ParentId = context.Categories.FirstOrDefault(c=> c.Name == txtParentName.Text).Id;
                category.Image = ImageWorker.ImageSaveUrl(txtUrl.Text, "categories");
                category.Name = txtName.Text;
                if (txtPriority.Text != string.Empty) category.Priority = Convert.ToInt16(txtPriority.Text);
                category.Description = txtDescription.Text;
                context.Categories.Add(category);
                context.SaveChanges();
            }
            this.Close();
        }
    }
}
