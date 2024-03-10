namespace Booking.Forms.Apartment
{
    partial class ApartmentListForm
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
            btnCraeteApartment = new Button();
            lvImages = new ListView();
            btnFindByPrice = new Button();
            btnFindByBeds = new Button();
            btnFindByRooms = new Button();
            txtPrice = new TextBox();
            txtNumberOfBeds = new TextBox();
            txtNumberOfRooms = new TextBox();
            btnShowAll = new Button();
            SuspendLayout();
            // 
            // btnCraeteApartment
            // 
            btnCraeteApartment.Location = new Point(33, 39);
            btnCraeteApartment.Name = "btnCraeteApartment";
            btnCraeteApartment.Size = new Size(112, 46);
            btnCraeteApartment.TabIndex = 11;
            btnCraeteApartment.Text = "Створити";
            btnCraeteApartment.UseVisualStyleBackColor = true;
            btnCraeteApartment.Click += btnCreateApartment_Click;
            // 
            // lvImages
            // 
            lvImages.Location = new Point(33, 128);
            lvImages.Name = "lvImages";
            lvImages.Size = new Size(968, 379);
            lvImages.TabIndex = 44;
            lvImages.UseCompatibleStateImageBehavior = false;
            lvImages.MouseClick += lvImages_MouseClick;
            lvImages.MouseDoubleClick += lvImages_MouseDoubleClick;
            // 
            // btnFindByPrice
            // 
            btnFindByPrice.Location = new Point(357, 12);
            btnFindByPrice.Name = "btnFindByPrice";
            btnFindByPrice.Size = new Size(215, 46);
            btnFindByPrice.TabIndex = 45;
            btnFindByPrice.Text = "Find by price";
            btnFindByPrice.UseVisualStyleBackColor = true;
            btnFindByPrice.Click += btnFindByPrice_Click;
            // 
            // btnFindByBeds
            // 
            btnFindByBeds.Location = new Point(357, 76);
            btnFindByBeds.Name = "btnFindByBeds";
            btnFindByBeds.Size = new Size(215, 46);
            btnFindByBeds.TabIndex = 46;
            btnFindByBeds.Text = "Find by number of beds";
            btnFindByBeds.UseVisualStyleBackColor = true;
            btnFindByBeds.Click += btnFindByBeds_Click;
            // 
            // btnFindByRooms
            // 
            btnFindByRooms.Location = new Point(794, 12);
            btnFindByRooms.Name = "btnFindByRooms";
            btnFindByRooms.Size = new Size(205, 46);
            btnFindByRooms.TabIndex = 47;
            btnFindByRooms.Text = "Find bu number of rooms";
            btnFindByRooms.UseVisualStyleBackColor = true;
            btnFindByRooms.Click += btnFindByRooms_Click;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 16F);
            txtPrice.Location = new Point(170, 15);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(181, 36);
            txtPrice.TabIndex = 48;
            txtPrice.TextChanged += textBox1_TextChanged;
            // 
            // txtNumberOfBeds
            // 
            txtNumberOfBeds.Font = new Font("Segoe UI", 16F);
            txtNumberOfBeds.Location = new Point(170, 79);
            txtNumberOfBeds.Name = "txtNumberOfBeds";
            txtNumberOfBeds.Size = new Size(181, 36);
            txtNumberOfBeds.TabIndex = 49;
            // 
            // txtNumberOfRooms
            // 
            txtNumberOfRooms.Font = new Font("Segoe UI", 16F);
            txtNumberOfRooms.Location = new Point(607, 15);
            txtNumberOfRooms.Name = "txtNumberOfRooms";
            txtNumberOfRooms.Size = new Size(181, 36);
            txtNumberOfRooms.TabIndex = 50;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(682, 68);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(215, 47);
            btnShowAll.TabIndex = 51;
            btnShowAll.Text = "Show all apartments";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // ApartmentListForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 538);
            Controls.Add(btnShowAll);
            Controls.Add(txtNumberOfRooms);
            Controls.Add(txtNumberOfBeds);
            Controls.Add(txtPrice);
            Controls.Add(btnFindByRooms);
            Controls.Add(btnFindByBeds);
            Controls.Add(btnFindByPrice);
            Controls.Add(lvImages);
            Controls.Add(btnCraeteApartment);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "ApartmentListForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Номери на поверсі";
            Load += ApartmentListForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCraeteApartment;
        private ListView lvImages;
        private Button btnFindByPrice;
        private Button btnFindByBeds;
        private Button btnFindByRooms;
        private TextBox txtPrice;
        private TextBox txtNumberOfBeds;
        private TextBox txtNumberOfRooms;
        private Button btnShowAll;
    }
}