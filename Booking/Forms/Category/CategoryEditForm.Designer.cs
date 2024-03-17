namespace Booking.Forms.Category
{
    partial class CategoryEditForm
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
            btnEdit = new Button();
            txtUrl = new TextBox();
            label5 = new Label();
            txtDescription = new TextBox();
            label4 = new Label();
            txtParentName = new TextBox();
            label3 = new Label();
            txtPriority = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 16F);
            btnEdit.Location = new Point(645, 48);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(114, 36);
            btnEdit.TabIndex = 21;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // txtUrl
            // 
            txtUrl.Font = new Font("Segoe UI", 16F);
            txtUrl.Location = new Point(279, 48);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(209, 36);
            txtUrl.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(279, 15);
            label5.Name = "label5";
            label5.Size = new Size(105, 30);
            label5.TabIndex = 19;
            label5.Text = "Image url";
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 16F);
            txtDescription.Location = new Point(41, 312);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(352, 123);
            txtDescription.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(41, 279);
            label4.Name = "label4";
            label4.Size = new Size(122, 30);
            label4.TabIndex = 17;
            label4.Text = "Description";
            // 
            // txtParentName
            // 
            txtParentName.Font = new Font("Segoe UI", 16F);
            txtParentName.Location = new Point(41, 226);
            txtParentName.Name = "txtParentName";
            txtParentName.Size = new Size(249, 36);
            txtParentName.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(41, 193);
            label3.Name = "label3";
            label3.Size = new Size(238, 30);
            label3.TabIndex = 15;
            label3.Text = "Parent name(optionaly)";
            // 
            // txtPriority
            // 
            txtPriority.Font = new Font("Segoe UI", 16F);
            txtPriority.Location = new Point(41, 137);
            txtPriority.Name = "txtPriority";
            txtPriority.Size = new Size(209, 36);
            txtPriority.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(41, 104);
            label2.Name = "label2";
            label2.Size = new Size(82, 30);
            label2.TabIndex = 13;
            label2.Text = "Priority";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 16F);
            txtName.Location = new Point(41, 48);
            txtName.Name = "txtName";
            txtName.Size = new Size(209, 36);
            txtName.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(41, 15);
            label1.Name = "label1";
            label1.Size = new Size(162, 30);
            label1.TabIndex = 11;
            label1.Text = "Category name";
            // 
            // CategoryEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEdit);
            Controls.Add(txtUrl);
            Controls.Add(label5);
            Controls.Add(txtDescription);
            Controls.Add(label4);
            Controls.Add(txtParentName);
            Controls.Add(label3);
            Controls.Add(txtPriority);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "CategoryEditForm";
            Text = "CategoryEditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEdit;
        private TextBox txtUrl;
        private Label label5;
        private TextBox txtDescription;
        private Label label4;
        private TextBox txtParentName;
        private Label label3;
        private TextBox txtPriority;
        private Label label2;
        private TextBox txtName;
        private Label label1;
    }
}