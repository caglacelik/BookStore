using Business.Concrete;
using DataAccess.Concrete;
using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Book_Store
{
    /**   
     * @brief    This file includes user interfaces and button operations.
     */
    public partial class Dashboard : Form
    {
        
        BookDal bookDal = new BookDal();
        MusicCDDal musicCDDal = new MusicCDDal();
        MagazineDal magazineDal = new MagazineDal();
        ShoppingCartDal shoppingCartDal = new ShoppingCartDal();
        ShoppingCart shoppingCart = new ShoppingCart(new ShoppingCartDal());
        Customer customer;

        /// <summary>
        /// This is constructor.
        /// Initialize the components.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        public Dashboard()
        {
            InitializeComponent();
            customer = CustomerManager.CreateAsSingleton().User;
            lblName.Text = customer.customerName;
        }

        /// <summary>
        /// This function loads the books when the book button clicked.
        /// Sets the UserControl designs of every book and add to flowlayoutpanel.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void btnBook_Click(object sender, EventArgs e)
        {
            LoggingClass.WriteLogWithButton(CustomerManager.CreateAsSingleton().User.customerName,(sender as Button).Text);
            pnlMyOrders.Visible = false;
            flowLayoutProducts.Controls.Clear();
            flowLayoutProducts.Visible = true;
            pnlCart.Visible = false;
            List<Book> bookList = new List<Book>();
            bookList = bookDal.GetAll();
            foreach (Book b in bookList)
            {
                BookDesign bookDesign = new BookDesign();
                bookDesign.setBookName(b.Name);
                bookDesign.setAuthor(b.Author);
                bookDesign.setPublisher(b.Publisher);
                bookDesign.setPrice(b.UnitPrice);
                bookDesign.setPage(b.Page);
                Button addCart = bookDesign.getAddButton();
                addCart.Click+= btnAddBookToCart;
                addCart.TabIndex = b.Id;
                flowLayoutProducts.Controls.Add(bookDesign);
            }
        }

        /// <summary>
        /// This function adds the book which its button clicked, to the shoppingcart.
        /// Function notices the button which is clicked.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        public void btnAddBookToCart(object sender, EventArgs e)
        {
            LoggingClass.WriteLogWithButton(CustomerManager.CreateAsSingleton().User.customerName, (sender as Button).Text);
            Book book = new Book();
            bookDal.getWithId((sender as Button).TabIndex, book);

            List<ItemToPurchase> items = shoppingCartDal.GetItemsToPurchase(customer.customerID);

            foreach (ItemToPurchase it in items)
            {
                if (it.Product.Id == book.Id)
                {
                    it.Quantity++;
                    shoppingCart.UpdateItemToPurchase(it);
                    return;
                }
            }
            ItemToPurchase itemToPurchase = new ItemToPurchase
            {
                Product = book,
                Quantity = 1
            };
            shoppingCart.AddProduct(itemToPurchase);

        }

        /// <summary>
        /// This function is LogOut function.
        /// When it is clicked, user will be logged out.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoggingClass.WriteLogWithButton(CustomerManager.CreateAsSingleton().User.customerName, (sender as Button).Text);
            Login Login = new Login();
            this.Hide();
            Login.ShowDialog();
        }

        /// <summary>
        /// This function opens the panel of shopping cart.
        /// Shows the every item and their quantities in the datagridview.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void btnCart_Click(object sender, EventArgs e)
        {
            LoggingClass.WriteLogWithButton(CustomerManager.CreateAsSingleton().User.customerName, (sender as Button).Text);
            pnlMyOrders.Visible = false;
            flowLayoutProducts.Visible = false;
            double totalPrice = 0;
            pnlCart.Visible = true;
            List<ShoppingCartDetailDTO> shop;
            shop = shoppingCartDal.GetByCustomerId(customer.customerID);
            foreach (ShoppingCartDetailDTO s in shop)
            {
                totalPrice += s.TotalPrice;
            }

            dataGridView1.DataSource = shop;
            txtPrice.Text = totalPrice.ToString();
            if (dataGridView1.Rows.Count > 0 && dataGridView1.Rows != null)
            {
                lblIsCardEmpty.Visible = false;
                txtPrice.Visible = true;
                btnPayment.Visible = true;
                btnClearCart.Visible = true;
                dataGridView1.Visible = true;
                lblTotal.Visible = true;
            }
            else
            {
                lblTotal.Visible = false;
                txtPrice.Visible = false;
                btnPayment.Visible = false;
                btnClearCart.Visible = false;
                dataGridView1.Visible = false;
                lblIsCardEmpty.Visible = true;
            }
        }

        /// <summary>
        /// This function clears every item in the shopping cart.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void btnClearCart_Click(object sender, EventArgs e)
        {
            LoggingClass.WriteLogWithButton(CustomerManager.CreateAsSingleton().User.customerName, (sender as Button).Text);
            lblTotal.Visible = false;
            txtPrice.Visible = false;
            btnPayment.Visible = false;
            btnClearCart.Visible = false;
            dataGridView1.Visible = false;
            lblIsCardEmpty.Visible = true;
            shoppingCartDal.ClearCart(customer.customerID);
        }

        /// <summary>
        /// This function loads the magazines when the book button clicked.
        /// Sets the UserControl designs of every magazine and add to flowlayoutpanel.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void btnMagazine_Click(object sender, EventArgs e)
        {
            LoggingClass.WriteLogWithButton(CustomerManager.CreateAsSingleton().User.customerName, (sender as Button).Text);
            pnlMyOrders.Visible = false;
            flowLayoutProducts.Controls.Clear();
            flowLayoutProducts.Visible = true;
            pnlCart.Visible = false;
            List<Magazine> magazineList = new List<Magazine>();
            magazineList = magazineDal.GetAll();
            foreach (Magazine b in magazineList)
            {
                MagazineDesign magazineDesign = new MagazineDesign();
                magazineDesign.setBookName(b.Name);
                magazineDesign.setIssue(b.Issue);
                magazineDesign.setPrice(b.UnitPrice);
                Button addCart = magazineDesign.getAddButton();
                addCart.Click += btnAddMagazineToCard;
                addCart.TabIndex = b.Id;
                flowLayoutProducts.Controls.Add(magazineDesign);
            }
        }

        /// <summary>
        /// This function adds the magazine which its button clicked, to the shoppingcart.
        /// Function notices the button which is clicked.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        public void btnAddMagazineToCard(object sender, EventArgs e)
        {
            LoggingClass.WriteLogWithButton(CustomerManager.CreateAsSingleton().User.customerName, (sender as Button).Text);
            Magazine magazine = new Magazine();
            magazineDal.getWithId((sender as Button).TabIndex, magazine);
            List<ItemToPurchase> items = shoppingCartDal.GetItemsToPurchase(customer.customerID);

            foreach (ItemToPurchase it in items)
            {
                if (it.Product.Id == magazine.Id)
                {
                    it.Quantity++;
                    shoppingCart.UpdateItemToPurchase(it);
                    return;
                }
            }
            ItemToPurchase itemToPurchase = new ItemToPurchase
            {
                Product = magazine,
                Quantity = 1
            };
            shoppingCart.AddProduct(itemToPurchase);
        }

        /// <summary>
        /// This function loads the music CDs when the book button clicked.
        /// Sets the UserControl designs of every CD and add to flowlayoutpanel.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void btnCD_Click(object sender, EventArgs e)
        {
            LoggingClass.WriteLogWithButton(CustomerManager.CreateAsSingleton().User.customerName, (sender as Button).Text);
            pnlMyOrders.Visible = false;
            flowLayoutProducts.Controls.Clear();
            flowLayoutProducts.Visible = true;
            pnlCart.Visible = false;
            List<MusicCD> CDList = new List<MusicCD>();
            CDList = musicCDDal.GetAll();
            foreach (MusicCD b in CDList)
            {
                CDsDesign cdsDesign = new CDsDesign();
                cdsDesign.setCDName(b.Name);
                cdsDesign.setSinger(b.Singer);
                cdsDesign.setType(b.Type.ToString());
                cdsDesign.setPrice(b.UnitPrice);
                Button addCart = cdsDesign.getAddButton();
                addCart.Click += btnAddCDToCart;
                addCart.TabIndex = b.Id;
                flowLayoutProducts.Controls.Add(cdsDesign);
            }
        }

        /// <summary>
        /// This function adds the music CD which its button clicked, to the shoppingcart.
        /// Function notices the button which is clicked.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        public void btnAddCDToCart(object sender, EventArgs e)
        {
            LoggingClass.WriteLogWithButton(CustomerManager.CreateAsSingleton().User.customerName, (sender as Button).Text);
            MusicCD cd= new MusicCD();
            musicCDDal.getWithId((sender as Button).TabIndex, cd);
            List<ItemToPurchase> items = shoppingCartDal.GetItemsToPurchase(customer.customerID);

            foreach (ItemToPurchase it in items)
            {
                if (it.Product.Id == cd.Id)
                {
                    it.Quantity++;
                    shoppingCart.UpdateItemToPurchase(it);
                    return;
                }
            }
            ItemToPurchase itemToPurchase = new ItemToPurchase
            {
                Product = cd,
                Quantity = 1
            };
            shoppingCart.AddProduct(itemToPurchase);
        }

        /// <summary>
        /// This function opens the Order panel.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void btnPayment_Click(object sender, EventArgs e)
        {
            LoggingClass.WriteLogWithButton(CustomerManager.CreateAsSingleton().User.customerName, (sender as Button).Text);
            pnlOrder.Visible = true;
        }

        /// <summary>
        /// This function places the order.
        /// When order is completed, shopping cart will be cleared.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void btnOrder_Click(object sender, EventArgs e)
        {
            LoggingClass.WriteLogWithButton(CustomerManager.CreateAsSingleton().User.customerName, (sender as Button).Text);
            if (cmbPaymentType.SelectedItem == null)
            {
                MessageBox.Show("You have to select payment type!");
            }

            else
            {
                PaymentType paymentType = (PaymentType)Enum.Parse(typeof(PaymentType), cmbPaymentType.SelectedItem.ToString());
                shoppingCart.PlaceOrder(paymentType);

                shoppingCartDal.ClearCart(customer.customerID);
                MessageBox.Show("You have ordered successfully!");
                lblIsCardEmpty.Visible = true;
                pnlOrder.Visible = false;
                lblTotal.Visible = false;
                txtPrice.Visible = false;
                btnPayment.Visible = false;
                btnClearCart.Visible = false;
                dataGridView1.Visible = false;
            }
        }

        /// <summary>
        /// This function loads the orders that user places.
        /// Every order are listed in datagridview.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void btnOrders_Click(object sender, EventArgs e)
        {
            LoggingClass.WriteLogWithButton(CustomerManager.CreateAsSingleton().User.customerName, (sender as Button).Text);
            OrderDal orderDal = new OrderDal();
            List<Order> orders = orderDal.GetOrders(customer.customerID);
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = orders;
            pnlCart.Visible = false;
            pnlMyOrders.Visible = true;

            if (dataGridView2.Rows.Count > 0 && dataGridView2.Rows != null)
            {
                lblisOrdersEmpty.Text = "";
                btnCancelOrder.Visible = true;
                dataGridView2.Visible = true;
            }
            else
            {
                btnCancelOrder.Visible = false;
                dataGridView2.Visible = false;
                lblisOrdersEmpty.Text = "You don't have any orders.";
            }
        }

        /// <summary>
        /// This function cancels the order that is selected.
        /// Order will be removed when the button clicked.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            LoggingClass.WriteLogWithButton(CustomerManager.CreateAsSingleton().User.customerName, (sender as Button).Text);
            OrderDal orderDal = new OrderDal();

            if (dataGridView2.Rows.Count > 0 && dataGridView2.Rows != null)
            {
                int cancelOrderId = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["Id"].Value);
                shoppingCart.CancelOrder(cancelOrderId);
                MessageBox.Show("You have deleted order!");

                List<Order> orders = orderDal.GetOrders(customer.customerID);
                dataGridView2.AutoGenerateColumns = false;
                dataGridView2.DataSource = orders;
                if (dataGridView2.Rows.Count > 0 && dataGridView2.Rows != null)
                {
                    return;
                }
                else
                {
                    btnCancelOrder.Visible = false;
                    dataGridView2.Visible = false;
                    lblisOrdersEmpty.Text = "You don't have any orders.";
                }
            }
            else
            {
                MessageBox.Show("You have to select one order!");
            }
            
        }


    }
}
