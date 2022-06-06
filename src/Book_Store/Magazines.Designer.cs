
namespace Book_Store
{
    partial class MagazineDesign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MagazineDesign));
            this.pnlAdet = new System.Windows.Forms.Panel();
            this.btnAddCart = new System.Windows.Forms.Button();
            this.lblIssue = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.pnlAdet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAdet
            // 
            this.pnlAdet.Controls.Add(this.btnAddCart);
            this.pnlAdet.Location = new System.Drawing.Point(0, 306);
            this.pnlAdet.Name = "pnlAdet";
            this.pnlAdet.Size = new System.Drawing.Size(214, 69);
            this.pnlAdet.TabIndex = 12;
            // 
            // btnAddCart
            // 
            this.btnAddCart.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddCart.Location = new System.Drawing.Point(71, 12);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(72, 44);
            this.btnAddCart.TabIndex = 4;
            this.btnAddCart.Text = "Add";
            this.btnAddCart.UseVisualStyleBackColor = true;
            // 
            // lblIssue
            // 
            this.lblIssue.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIssue.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblIssue.Location = new System.Drawing.Point(3, 134);
            this.lblIssue.Name = "lblIssue";
            this.lblIssue.Size = new System.Drawing.Size(208, 14);
            this.lblIssue.TabIndex = 11;
            this.lblIssue.Text = "Turkuaz Yayınları";
            this.lblIssue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Georgia", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(3, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(208, 23);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Vogue";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(49, 281);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(117, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice.Location = new System.Drawing.Point(3, 215);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(208, 18);
            this.lblPrice.TabIndex = 13;
            this.lblPrice.Text = "20,00 TL";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPublisher
            // 
            this.lblPublisher.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPublisher.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPublisher.Location = new System.Drawing.Point(3, 152);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(208, 14);
            this.lblPublisher.TabIndex = 14;
            this.lblPublisher.Text = "Turkuaz Yayınları";
            this.lblPublisher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MagazineDesign
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.pnlAdet);
            this.Controls.Add(this.lblIssue);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pictureBox2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MagazineDesign";
            this.Size = new System.Drawing.Size(215, 378);
            this.pnlAdet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAdet;
        private System.Windows.Forms.Button btnAddCart;
        private System.Windows.Forms.Label lblIssue;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPublisher;
    }
}