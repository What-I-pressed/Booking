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
            btnDelete = new Button();
            txtDelete = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtEdit = new TextBox();
            btnEdit = new Button();
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
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 16F);
            btnDelete.Location = new Point(434, 88);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(154, 39);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete category";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtDelete
            // 
            txtDelete.Font = new Font("Segoe UI", 12F);
            txtDelete.Location = new Point(614, 96);
            txtDelete.Name = "txtDelete";
            txtDelete.Size = new Size(198, 29);
            txtDelete.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(614, 72);
            label1.Name = "label1";
            label1.Size = new Size(198, 21);
            label1.TabIndex = 4;
            label1.Text = "Name of category to delete";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(614, 154);
            label2.Name = "label2";
            label2.Size = new Size(182, 21);
            label2.TabIndex = 7;
            label2.Text = "Name of category to edit";
            // 
            // txtEdit
            // 
            txtEdit.Font = new Font("Segoe UI", 12F);
            txtEdit.Location = new Point(614, 178);
            txtEdit.Name = "txtEdit";
            txtEdit.Size = new Size(198, 29);
            txtEdit.TabIndex = 6;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 16F);
            btnEdit.Location = new Point(434, 170);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(154, 39);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // CategoryListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 387);
            Controls.Add(label2);
            Controls.Add(txtEdit);
            Controls.Add(btnEdit);
            Controls.Add(label1);
            Controls.Add(txtDelete);
            Controls.Add(btnDelete);
            Controls.Add(btnAddCategory);
            Controls.Add(tvCategory);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CategoryListForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Керування категоріями";
            Load += CategoryListForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView tvCategory;
        private Button btnAddCategory;
        private Button btnDelete;
        private TextBox txtDelete;
        private Label label1;
        private Label label2;
        private TextBox txtEdit;
        private Button btnEdit;
    }
}