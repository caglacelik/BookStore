
namespace Book_Store
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.pcboxStoreBackground = new System.Windows.Forms.PictureBox();
            this.pnlStoreScreen = new System.Windows.Forms.Panel();
            this.pnlMyOrders = new System.Windows.Forms.Panel();
            this.lblisOrdersEmpty = new System.Windows.Forms.Label();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnCD = new System.Windows.Forms.Button();
            this.btnMagazine = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.pnlProduct = new System.Windows.Forms.Panel();
            this.pnlCart = new System.Windows.Forms.Panel();
            this.lblOrderSuccessed = new System.Windows.Forms.Label();
            this.pnlOrder = new System.Windows.Forms.Panel();
            this.btnOrder = new System.Windows.Forms.Button();
            this.cmbPaymentType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPayment = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblIsCardEmpty = new System.Windows.Forms.Label();
            this.btnClearCart = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcboxStoreBackground)).BeginInit();
            this.pnlStoreScreen.SuspendLayout();
            this.pnlMyOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlSideBar.SuspendLayout();
            this.pnlProduct.SuspendLayout();
            this.pnlCart.SuspendLayout();
            this.pnlOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pcboxStoreBackground
            // 
            this.pcboxStoreBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcboxStoreBackground.Image = ((System.Drawing.Image)(resources.GetObject("pcboxStoreBackground.Image")));
            this.pcboxStoreBackground.Location = new System.Drawing.Point(0, 0);
            this.pcboxStoreBackground.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pcboxStoreBackground.Name = "pcboxStoreBackground";
            this.pcboxStoreBackground.Size = new System.Drawing.Size(1274, 764);
            this.pcboxStoreBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcboxStoreBackground.TabIndex = 0;
            this.pcboxStoreBackground.TabStop = false;
            // 
            // pnlStoreScreen
            // 
            this.pnlStoreScreen.BackColor = System.Drawing.SystemColors.Info;
            this.pnlStoreScreen.Controls.Add(this.pnlMyOrders);
            this.pnlStoreScreen.Controls.Add(this.pictureBox2);
            this.pnlStoreScreen.Controls.Add(this.pictureBox1);
            this.pnlStoreScreen.Controls.Add(this.pnlSideBar);
            this.pnlStoreScreen.Controls.Add(this.pnlProduct);
            this.pnlStoreScreen.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlStoreScreen.Location = new System.Drawing.Point(85, 69);
            this.pnlStoreScreen.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlStoreScreen.Name = "pnlStoreScreen";
            this.pnlStoreScreen.Size = new System.Drawing.Size(1105, 627);
            this.pnlStoreScreen.TabIndex = 1;
            // 
            // pnlMyOrders
            // 
            this.pnlMyOrders.Controls.Add(this.lblisOrdersEmpty);
            this.pnlMyOrders.Controls.Add(this.btnCancelOrder);
            this.pnlMyOrders.Controls.Add(this.dataGridView2);
            this.pnlMyOrders.Location = new System.Drawing.Point(201, 88);
            this.pnlMyOrders.Name = "pnlMyOrders";
            this.pnlMyOrders.Size = new System.Drawing.Size(903, 539);
            this.pnlMyOrders.TabIndex = 8;
            this.pnlMyOrders.Visible = false;
            // 
            // lblisOrdersEmpty
            // 
            this.lblisOrdersEmpty.AutoSize = true;
            this.lblisOrdersEmpty.BackColor = System.Drawing.SystemColors.Info;
            this.lblisOrdersEmpty.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblisOrdersEmpty.Location = new System.Drawing.Point(50, 32);
            this.lblisOrdersEmpty.Name = "lblisOrdersEmpty";
            this.lblisOrdersEmpty.Size = new System.Drawing.Size(50, 18);
            this.lblisOrdersEmpty.TabIndex = 2;
            this.lblisOrdersEmpty.Text = "asfasf";
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelOrder.Location = new System.Drawing.Point(408, 267);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(167, 37);
            this.btnCancelOrder.TabIndex = 1;
            this.btnCancelOrder.Text = "Cancel order";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Price,
            this.PaymentType,
            this.Date});
            this.dataGridView2.Location = new System.Drawing.Point(20, 8);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(555, 241);
            this.dataGridView2.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 49;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "TotalPrice";
            this.Price.HeaderText = "Total Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 104;
            // 
            // PaymentType
            // 
            this.PaymentType.DataPropertyName = "paymentType";
            this.PaymentType.HeaderText = "Payment Type";
            this.PaymentType.Name = "PaymentType";
            this.PaymentType.ReadOnly = true;
            this.PaymentType.Width = 127;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 67;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(104, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(101, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(619, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackColor = System.Drawing.SystemColors.Info;
            this.pnlSideBar.Controls.Add(this.btnLogOut);
            this.pnlSideBar.Controls.Add(this.btnOrders);
            this.pnlSideBar.Controls.Add(this.btnCart);
            this.pnlSideBar.Controls.Add(this.btnCD);
            this.pnlSideBar.Controls.Add(this.btnMagazine);
            this.pnlSideBar.Controls.Add(this.btnBook);
            this.pnlSideBar.Location = new System.Drawing.Point(0, 88);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(202, 536);
            this.pnlSideBar.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.SystemColors.Info;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.ForeColor = System.Drawing.Color.Gray;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(35, 453);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(137, 31);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.SystemColors.Info;
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.ForeColor = System.Drawing.Color.Gray;
            this.btnOrders.Image = ((System.Drawing.Image)(resources.GetObject("btnOrders.Image")));
            this.btnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.Location = new System.Drawing.Point(35, 406);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(137, 31);
            this.btnOrders.TabIndex = 5;
            this.btnOrders.Text = "My Orders";
            this.btnOrders.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnCart
            // 
            this.btnCart.BackColor = System.Drawing.SystemColors.Info;
            this.btnCart.FlatAppearance.BorderSize = 0;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.ForeColor = System.Drawing.Color.Gray;
            this.btnCart.Image = ((System.Drawing.Image)(resources.GetObject("btnCart.Image")));
            this.btnCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCart.Location = new System.Drawing.Point(35, 360);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(137, 31);
            this.btnCart.TabIndex = 4;
            this.btnCart.Text = "Cart";
            this.btnCart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCart.UseVisualStyleBackColor = false;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnCD
            // 
            this.btnCD.BackColor = System.Drawing.SystemColors.Info;
            this.btnCD.FlatAppearance.BorderSize = 0;
            this.btnCD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCD.ForeColor = System.Drawing.Color.Gray;
            this.btnCD.Image = ((System.Drawing.Image)(resources.GetObject("btnCD.Image")));
            this.btnCD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCD.Location = new System.Drawing.Point(35, 129);
            this.btnCD.Name = "btnCD";
            this.btnCD.Size = new System.Drawing.Size(137, 31);
            this.btnCD.TabIndex = 3;
            this.btnCD.Text = "CDs";
            this.btnCD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCD.UseVisualStyleBackColor = false;
            this.btnCD.Click += new System.EventHandler(this.btnCD_Click);
            // 
            // btnMagazine
            // 
            this.btnMagazine.BackColor = System.Drawing.SystemColors.Info;
            this.btnMagazine.FlatAppearance.BorderSize = 0;
            this.btnMagazine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMagazine.ForeColor = System.Drawing.Color.Gray;
            this.btnMagazine.Image = ((System.Drawing.Image)(resources.GetObject("btnMagazine.Image")));
            this.btnMagazine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMagazine.Location = new System.Drawing.Point(35, 80);
            this.btnMagazine.Name = "btnMagazine";
            this.btnMagazine.Size = new System.Drawing.Size(137, 31);
            this.btnMagazine.TabIndex = 2;
            this.btnMagazine.Text = "Magazines";
            this.btnMagazine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMagazine.UseVisualStyleBackColor = false;
            this.btnMagazine.Click += new System.EventHandler(this.btnMagazine_Click);
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.SystemColors.Info;
            this.btnBook.FlatAppearance.BorderSize = 0;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.ForeColor = System.Drawing.Color.Gray;
            this.btnBook.Image = ((System.Drawing.Image)(resources.GetObject("btnBook.Image")));
            this.btnBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBook.Location = new System.Drawing.Point(35, 32);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(137, 31);
            this.btnBook.TabIndex = 1;
            this.btnBook.Text = "Books";
            this.btnBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // pnlProduct
            // 
            this.pnlProduct.BackColor = System.Drawing.SystemColors.Info;
            this.pnlProduct.Controls.Add(this.pnlCart);
            this.pnlProduct.Controls.Add(this.flowLayoutProducts);
            this.pnlProduct.Location = new System.Drawing.Point(202, 88);
            this.pnlProduct.Name = "pnlProduct";
            this.pnlProduct.Size = new System.Drawing.Size(900, 539);
            this.pnlProduct.TabIndex = 1;
            // 
            // pnlCart
            // 
            this.pnlCart.Controls.Add(this.lblOrderSuccessed);
            this.pnlCart.Controls.Add(this.pnlOrder);
            this.pnlCart.Controls.Add(this.btnPayment);
            this.pnlCart.Controls.Add(this.txtPrice);
            this.pnlCart.Controls.Add(this.lblTotal);
            this.pnlCart.Controls.Add(this.lblIsCardEmpty);
            this.pnlCart.Controls.Add(this.btnClearCart);
            this.pnlCart.Controls.Add(this.dataGridView1);
            this.pnlCart.Location = new System.Drawing.Point(0, 0);
            this.pnlCart.Name = "pnlCart";
            this.pnlCart.Size = new System.Drawing.Size(903, 539);
            this.pnlCart.TabIndex = 2;
            this.pnlCart.Visible = false;
            // 
            // lblOrderSuccessed
            // 
            this.lblOrderSuccessed.AutoSize = true;
            this.lblOrderSuccessed.Location = new System.Drawing.Point(20, 360);
            this.lblOrderSuccessed.Name = "lblOrderSuccessed";
            this.lblOrderSuccessed.Size = new System.Drawing.Size(0, 18);
            this.lblOrderSuccessed.TabIndex = 7;
            // 
            // pnlOrder
            // 
            this.pnlOrder.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pnlOrder.Controls.Add(this.btnOrder);
            this.pnlOrder.Controls.Add(this.cmbPaymentType);
            this.pnlOrder.Controls.Add(this.label3);
            this.pnlOrder.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlOrder.Location = new System.Drawing.Point(567, 0);
            this.pnlOrder.Name = "pnlOrder";
            this.pnlOrder.Size = new System.Drawing.Size(330, 271);
            this.pnlOrder.TabIndex = 6;
            this.pnlOrder.Visible = false;
            // 
            // btnOrder
            // 
            this.btnOrder.ForeColor = System.Drawing.Color.Black;
            this.btnOrder.Location = new System.Drawing.Point(135, 80);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(121, 31);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // cmbPaymentType
            // 
            this.cmbPaymentType.FormattingEnabled = true;
            this.cmbPaymentType.Items.AddRange(new object[] {
            "CreditCard",
            "DebitCard",
            "Cash"});
            this.cmbPaymentType.Location = new System.Drawing.Point(135, 13);
            this.cmbPaymentType.Name = "cmbPaymentType";
            this.cmbPaymentType.Size = new System.Drawing.Size(121, 26);
            this.cmbPaymentType.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(14, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Payment Type";
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(461, 325);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(100, 31);
            this.btnPayment.TabIndex = 5;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(461, 278);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 26);
            this.txtPrice.TabIndex = 4;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(362, 286);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(102, 18);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total Price : ";
            // 
            // lblIsCardEmpty
            // 
            this.lblIsCardEmpty.AutoSize = true;
            this.lblIsCardEmpty.Location = new System.Drawing.Point(17, 32);
            this.lblIsCardEmpty.Name = "lblIsCardEmpty";
            this.lblIsCardEmpty.Size = new System.Drawing.Size(318, 18);
            this.lblIsCardEmpty.TabIndex = 2;
            this.lblIsCardEmpty.Text = "Your cart is empty. Please add some items!";
            // 
            // btnClearCart
            // 
            this.btnClearCart.Location = new System.Drawing.Point(6, 277);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(111, 36);
            this.btnClearCart.TabIndex = 1;
            this.btnClearCart.Text = "Clear Cart";
            this.btnClearCart.UseVisualStyleBackColor = true;
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.Quantity,
            this.ProductPrice,
            this.TotalPrice});
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(561, 268);
            this.dataGridView1.TabIndex = 0;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Item Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 115;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 97;
            // 
            // ProductPrice
            // 
            this.ProductPrice.DataPropertyName = "ProductPrice";
            this.ProductPrice.HeaderText = "Price";
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "TotalPrice";
            this.TotalPrice.HeaderText = "Total Price";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // flowLayoutProducts
            // 
            this.flowLayoutProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutProducts.AutoScroll = true;
            this.flowLayoutProducts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutProducts.BackColor = System.Drawing.Color.Bisque;
            this.flowLayoutProducts.Location = new System.Drawing.Point(0, 3);
            this.flowLayoutProducts.Name = "flowLayoutProducts";
            this.flowLayoutProducts.Size = new System.Drawing.Size(900, 536);
            this.flowLayoutProducts.TabIndex = 0;
            this.flowLayoutProducts.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(992, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(50, 18);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "label1";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 764);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pnlStoreScreen);
            this.Controls.Add(this.pcboxStoreBackground);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "G & B Book Store";
            ((System.ComponentModel.ISupportInitialize)(this.pcboxStoreBackground)).EndInit();
            this.pnlStoreScreen.ResumeLayout(false);
            this.pnlMyOrders.ResumeLayout(false);
            this.pnlMyOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlSideBar.ResumeLayout(false);
            this.pnlProduct.ResumeLayout(false);
            this.pnlCart.ResumeLayout(false);
            this.pnlCart.PerformLayout();
            this.pnlOrder.ResumeLayout(false);
            this.pnlOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcboxStoreBackground;
        private System.Windows.Forms.Panel pnlStoreScreen;
        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button btnCD;
        private System.Windows.Forms.Button btnMagazine;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel pnlProduct;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutProducts;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClearCart;
        private System.Windows.Forms.Panel pnlCart;
        private System.Windows.Forms.Label lblIsCardEmpty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel pnlOrder;
        private System.Windows.Forms.ComboBox cmbPaymentType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label lblOrderSuccessed;
        private System.Windows.Forms.Panel pnlMyOrders;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.Label lblisOrdersEmpty;
    }
}