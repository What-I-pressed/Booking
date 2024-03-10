namespace Booking.Forms.Category
{
    partial class CategoryCreationForm
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
            label1 = new Label();
            txtName = new TextBox();
            txtPriority = new TextBox();
            label2 = new Label();
            txtParentName = new TextBox();
            label3 = new Label();
            txtDescription = new TextBox();
            label4 = new Label();
            txtUrl = new TextBox();
            label5 = new Label();
            btnCreate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(30, 18);
            label1.Name = "label1";
            label1.Size = new Size(162, 30);
            label1.TabIndex = 0;
            label1.Text = "Category name";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 16F);
            txtName.Location = new Point(30, 51);
            txtName.Name = "txtName";
            txtName.Size = new Size(209, 36);
            txtName.TabIndex = 1;
            // 
            // txtPriority
            // 
            txtPriority.Font = new Font("Segoe UI", 16F);
            txtPriority.Location = new Point(30, 140);
            txtPriority.Name = "txtPriority";
            txtPriority.Size = new Size(209, 36);
            txtPriority.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(30, 107);
            label2.Name = "label2";
            label2.Size = new Size(82, 30);
            label2.TabIndex = 2;
            label2.Text = "Priority";
            // 
            // txtParentId
            // 
            txtParentName.Font = new Font("Segoe UI", 16F);
            txtParentName.Location = new Point(30, 229);
            txtParentName.Name = "txtParentId";
            txtParentName.Size = new Size(249, 36);
            txtParentName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(30, 196);
            label3.Name = "label3";
            label3.Size = new Size(238, 30);
            label3.TabIndex = 4;
            label3.Text = "Parent name(optionaly)";
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 16F);
            txtDescription.Location = new Point(30, 315);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(352, 123);
            txtDescription.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(30, 282);
            label4.Name = "label4";
            label4.Size = new Size(122, 30);
            label4.TabIndex = 6;
            label4.Text = "Description";
            // 
            // txtUrl
            // 
            txtUrl.Font = new Font("Segoe UI", 16F);
            txtUrl.Location = new Point(268, 51);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(209, 36);
            txtUrl.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(268, 18);
            label5.Name = "label5";
            label5.Size = new Size(105, 30);
            label5.TabIndex = 8;
            label5.Text = "Image url";
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Segoe UI", 16F);
            btnCreate.Location = new Point(634, 51);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(114, 36);
            btnCreate.TabIndex = 10;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // CategoryCreationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCreate);
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
            Name = "CategoryCreationForm";
            Text = "CategoryCreationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private TextBox txtPriority;
        private Label label2;
        private TextBox txtParentName;
        private Label label3;
        private TextBox txtDescription;
        private Label label4;
        private TextBox txtUrl;
        private Label label5;
        private Button btnCreate;
    }
}