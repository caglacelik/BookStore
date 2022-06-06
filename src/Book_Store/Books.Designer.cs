
namespace Book_Store
{
    partial class BookDesign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookDesign));
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.btnAddCart = new System.Windows.Forms.Button();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.pnlAdet = new System.Windows.Forms.Panel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblPage = new System.Windows.Forms.Label();
            this.pnlAdet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBookName
            // 
            this.lblBookName.Font = new System.Drawing.Font("Georgia", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBookName.Location = new System.Drawing.Point(5, 47);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(207, 23);
            this.lblBookName.TabIndex = 1;
            this.lblBookName.Text = "Huzur";
            this.lblBookName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAuthor
            // 
            this.lblAuthor.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAuthor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAuthor.Location = new System.Drawing.Point(4, 121);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(208, 18);
            this.lblAuthor.TabIndex = 3;
            this.lblAuthor.Text = "Ahmet Hamdi Tanpınar";
            this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddCart
            // 
            this.btnAddCart.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddCart.Location = new System.Drawing.Point(69, 18);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(78, 43);
            this.btnAddCart.TabIndex = 4;
            this.btnAddCart.Text = "Add";
            this.btnAddCart.UseVisualStyleBackColor = true;
            // 
            // lblPublisher
            // 
            this.lblPublisher.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPublisher.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPublisher.Location = new System.Drawing.Point(6, 139);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(205, 14);
            this.lblPublisher.TabIndex = 5;
            this.lblPublisher.Text = "İş Bankası Yayınları";
            this.lblPublisher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlAdet
            // 
            this.pnlAdet.Controls.Add(this.btnAddCart);
            this.pnlAdet.Location = new System.Drawing.Point(5, 301);
            this.pnlAdet.Name = "pnlAdet";
            this.pnlAdet.Size = new System.Drawing.Size(206, 77);
            this.pnlAdet.TabIndex = 6;
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice.Location = new System.Drawing.Point(7, 212);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(203, 18);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "30,50 TL";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(50, 276);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(117, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // lblPage
            // 
            this.lblPage.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPage.Location = new System.Drawing.Point(6, 162);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(205, 14);
            this.lblPage.TabIndex = 8;
            this.lblPage.Text = "190 Pages";
            this.lblPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BookDesign
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.pnlAdet);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.pictureBox2);
            this.Name = "BookDesign";
            this.Size = new System.Drawing.Size(215, 378);
            this.pnlAdet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Button btnAddCart;
        private System.Windows.Forms.Panel pnlAdet;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblPage;
    }
}