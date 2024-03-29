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

namespace Booking.Forms.Category
{
    public partial class CategoryListForm : Form
    {
        public CategoryListForm()
        {
            InitializeComponent();
            tvCategory.ImageList = new ImageList();
        }

        private void CategoryListForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            tvCategory.Nodes.Clear(); //очишчаємо список гілок в дереві
            tvCategory.ImageList = new ImageList();
            tvCategory.ImageList.ImageSize = new Size(40, 40);
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                var items = db.Categories.Where(x => x.ParentId == null).ToList();
                foreach (var item in items)
                {
                    string id = item.Id.ToString();
                    string imageName = item.Image ?? "default.webp";
                    string fodler = item.Image == null ? "" : "categories";
                    var dir = Path.Combine(Directory.GetCurrentDirectory(), "images", fodler);
                    var imagePath = Path.Combine(dir, "150_" + imageName);

                    tvCategory.ImageList.Images.Add(id,
                        Image.FromStream(ImageWorker.GetFileStream(imagePath)));

                    TreeNode node = new TreeNode(item.Name);
                    node.Tag = item;
                    node.ImageKey = id;
                    node.SelectedImageKey = id;
                    node.Nodes.Add("");
                    tvCategory.Nodes.Add(node);
                }
            }
        }

        private void tvCategory_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var hitTest = e.Node.TreeView.HitTest(e.Location);
            if (hitTest.Location != TreeViewHitTestLocations.PlusMinus)
                return;
            if (!e.Node.IsExpanded)
                return;
            var parent = e.Node.Tag as CategoryEntity;
            e.Node.Nodes.Clear();
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                var list = db.Categories.Where(x => x.ParentId == parent.Id).ToList();
                if (list.Count() > 0)
                {
                    foreach (var item in list)
                    {
                        string id = item.Id.ToString();
                        string imageName = item.Image ?? "default.webp";
                        string fodler = item.Image == null ? "" : "categories";
                        var dir = Path.Combine(Directory.GetCurrentDirectory(), "images", fodler);
                        var imagePath = Path.Combine(dir, "150_" + imageName);

                        tvCategory.ImageList.Images.Add(id,
                            Image.FromStream(ImageWorker.GetFileStream(imagePath)));

                        TreeNode node = new TreeNode(item.Name);
                        node.Tag = item;
                        node.ImageKey = id;
                        node.SelectedImageKey = id;
                        node.Nodes.Add("");
                        e.Node.Nodes.Add(node);
                    }
                }
            }

        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            CategoryCreationForm dlg = new CategoryCreationForm();
            dlg.ShowDialog();
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string categoryName = txtDelete.Text;
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                context.Categories.Where(c => c.Name == categoryName).ExecuteDelete();
                context.SaveChanges();
            }
            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            CategoryEditForm dlg = new CategoryEditForm();
            dlg.Name = txtEdit.Text;
            dlg.ShowDialog();
            LoadData();
        }
    }
}
