namespace Booking.Forms.Category
{
    partial class CategoryListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tvCategory = new TreeView();
            btnAddCategory = new Button();
            SuspendLayout();
            // 
            // tvCategory
            // 
            tvCategory.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tvCategory.ItemHeight = 44;
            tvCategory.Location = new Point(18, 9);
            tvCategory.Margin = new Padding(3, 2, 3, 2);
            tvCategory.Name = "tvCategory";
            tvCategory.Size = new Size(392, 361);
            tvCategory.TabIndex = 0;
            tvCategory.NodeMouseClick += tvCategory_NodeMouseClick;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Font = new Font("Segoe UI", 16F);
            btnAddCategory.Location = new Point(446, 9);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(154, 39);
            btnAddCategory.TabIndex = 1;
            btnAddCategory.Text = "Add category";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // CategoryListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 387);
            Controls.Add(btnAddCategory);
            Controls.Add(tvCategory);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CategoryListForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Керування категоріями";
            Load += CategoryListForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private TreeView tvCategory;
        private Button btnAddCategory;
    }
}