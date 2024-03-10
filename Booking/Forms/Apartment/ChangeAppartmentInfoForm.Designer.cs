namespace Booking.Forms.Apartment
{
    partial class ChangeApartmentInfoForm
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
            btnSelectImages = new Button();
            lvImages = new ListView();
            txtNumberOfBeds = new TextBox();
            label4 = new Label();
            btnCancel = new Button();
            btnChange = new Button();
            txtPricePerNight = new TextBox();
            label3 = new Label();
            txtNumberOfRooms = new TextBox();
            label2 = new Label();
            txtNumber = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSelectImages
            // 
            btnSelectImages.Location = new Point(457, 104);
            btnSelectImages.Margin = new Padding(3, 2, 3, 2);
            btnSelectImages.Name = "btnSelectImages";
            btnSelectImages.Size = new Size(187, 35);
            btnSelectImages.TabIndex = 56;
            btnSelectImages.Text = "Додати фото";
            btnSelectImages.UseVisualStyleBackColor = true;
            btnSelectImages.Click += btnSelectImages_Click;
            // 
            // lvImages
            // 
            lvImages.Location = new Point(13, 151);
            lvImages.Margin = new Padding(3, 2, 3, 2);
            lvImages.Name = "lvImages";
            lvImages.Size = new Size(775, 268);
            lvImages.TabIndex = 55;
            lvImages.UseCompatibleStateImageBehavior = false;
            lvImages.SelectedIndexChanged += lvImages_SelectedIndexChanged;
            lvImages.MouseDoubleClick += lvImages_MouseDoubleClick;
            // 
            // txtNumberOfBeds
            // 
            txtNumberOfBeds.Location = new Point(222, 111);
            txtNumberOfBeds.Margin = new Padding(3, 2, 3, 2);
            txtNumberOfBeds.Name = "txtNumberOfBeds";
            txtNumberOfBeds.Size = new Size(173, 23);
            txtNumberOfBeds.TabIndex = 54;
            txtNumberOfBeds.Text = "1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(222, 88);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 53;
            label4.Text = "Кількість ліжок";
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(685, 77);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(98, 34);
            btnCancel.TabIndex = 51;
            btnCancel.Text = "Скасувати";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnChange
            // 
            btnChange.Location = new Point(685, 37);
            btnChange.Margin = new Padding(3, 2, 3, 2);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(98, 34);
            btnChange.TabIndex = 52;
            btnChange.Text = "Змінити";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // txtPricePerNight
            // 
            txtPricePerNight.Location = new Point(433, 54);
            txtPricePerNight.Margin = new Padding(3, 2, 3, 2);
            txtPricePerNight.Name = "txtPricePerNight";
            txtPricePerNight.Size = new Size(220, 23);
            txtPricePerNight.TabIndex = 48;
            txtPricePerNight.Text = "400";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(433, 31);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 45;
            label3.Text = "Ціна за добу";
            // 
            // txtNumberOfRooms
            // 
            txtNumberOfRooms.Location = new Point(13, 111);
            txtNumberOfRooms.Margin = new Padding(3, 2, 3, 2);
            txtNumberOfRooms.Name = "txtNumberOfRooms";
            txtNumberOfRooms.Size = new Size(173, 23);
            txtNumberOfRooms.TabIndex = 49;
            txtNumberOfRooms.Text = "1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(13, 88);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 46;
            label2.Text = "Кількість кімнат";
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(13, 54);
            txtNumber.Margin = new Padding(3, 2, 3, 2);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(381, 23);
            txtNumber.TabIndex = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(13, 31);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 47;
            label1.Text = "Номер кімнати";
            // 
            // ChangeApartmentInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSelectImages);
            Controls.Add(lvImages);
            Controls.Add(txtNumberOfBeds);
            Controls.Add(label4);
            Controls.Add(btnCancel);
            Controls.Add(btnChange);
            Controls.Add(txtPricePerNight);
            Controls.Add(label3);
            Controls.Add(txtNumberOfRooms);
            Controls.Add(label2);
            Controls.Add(txtNumber);
            Controls.Add(label1);
            Name = "ChangeApartmentInfoForm";
            Text = "ChangeAppartmentInfoForm";
            Load += ChangeApartmentInfoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelectImages;
        private ListView lvImages;
        private TextBox txtNumberOfBeds;
        private Label label4;
        private Button btnCancel;
        private Button btnChange;
        private TextBox txtPricePerNight;
        private Label label3;
        private TextBox txtNumberOfRooms;
        private Label label2;
        private TextBox txtNumber;
        private Label label1;
    }
}