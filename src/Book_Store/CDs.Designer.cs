
namespace Book_Store
{
    partial class CDsDesign
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CDsDesign));
            this.lblPrice = new System.Windows.Forms.Label();
            this.pnlAdet = new System.Windows.Forms.Panel();
            this.btnAddCart = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.lblSinger = new System.Windows.Forms.Label();
            this.lblCDName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlAdet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice.Location = new System.Drawing.Point(3, 214);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(209, 18);
            this.lblPrice.TabIndex = 14;
            this.lblPrice.Text = "30,50 TL";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlAdet
            // 
            this.pnlAdet.Controls.Add(this.btnAddCart);
            this.pnlAdet.Location = new System.Drawing.Point(3, 303);
            this.pnlAdet.Name = "pnlAdet";
            this.pnlAdet.Size = new System.Drawing.Size(209, 75);
            this.pnlAdet.TabIndex = 13;
            // 
            // btnAddCart
            // 
            this.btnAddCart.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddCart.Location = new System.Drawing.Point(71, 14);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(72, 49);
            this.btnAddCart.TabIndex = 4;
            this.btnAddCart.Text = "Add";
            this.btnAddCart.UseVisualStyleBackColor = true;
            // 
            // lblType
            // 
            this.lblType.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblType.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblType.Location = new System.Drawing.Point(4, 153);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(206, 14);
            this.lblType.TabIndex = 12;
            this.lblType.Text = "İş Bankası Yayınları";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSinger
            // 
            this.lblSinger.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSinger.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSinger.Location = new System.Drawing.Point(3, 135);
            this.lblSinger.Name = "lblSinger";
            this.lblSinger.Size = new System.Drawing.Size(209, 18);
            this.lblSinger.TabIndex = 11;
            this.lblSinger.Text = "Ahmet Hamdi Tanpınar";
            this.lblSinger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCDName
            // 
            this.lblCDName.Font = new System.Drawing.Font("Georgia", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCDName.Location = new System.Drawing.Point(4, 35);
            this.lblCDName.Name = "lblCDName";
            this.lblCDName.Size = new System.Drawing.Size(207, 23);
            this.lblCDName.TabIndex = 9;
            this.lblCDName.Text = "Huzur";
            this.lblCDName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(49, 278);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(117, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // CDsDesign
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.pnlAdet);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblSinger);
            this.Controls.Add(this.lblCDName);
            this.Controls.Add(this.pictureBox2);
            this.Name = "CDsDesign";
            this.Size = new System.Drawing.Size(215, 378);
            this.pnlAdet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Panel pnlAdet;
        private System.Windows.Forms.Button btnAddCart;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblSinger;
        private System.Windows.Forms.Label lblCDName;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
