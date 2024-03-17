using Helpers;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking.Forms.Category
{
    public partial class CategoryEditForm : Form
    {
        public string Name;
        public CategoryEditForm()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using(ApplicationDbContext context = new ApplicationDbContext())
            {
                context.Categories.Where(c => c.Name == Name)
                    .ExecuteUpdate( c => c.SetProperty(c => c.Name, txtName.Text)
                    .SetProperty(c => c.Priority, Convert.ToInt32(txtPriority.Text))
                    .SetProperty(c=> c.ParentId, context.Categories.FirstOrDefault(p => p.Name == txtParentName.Text).Id)
                    .SetProperty(c=> c.Description, txtDescription.Text)
                    .SetProperty(c => c.Image, ImageWorker.ImageSaveUrl(txtUrl.Text, "categories", null)));
                context.SaveChanges();
                context.SaveChanges();
            }
            this.Close();
        }
    }
}
