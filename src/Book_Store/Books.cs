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
    * @brief    This file includes book functions.
    */
    public partial class BookDesign : UserControl
    {

        public BookDesign()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This function sets book name.
        /// </summary>
        /// <param name="name">The name string hold the book name.</param>
        public void setBookName(string name)
        {
            lblBookName.Text = name;
        }
        /// <summary>
        /// This function sets author name.
        /// </summary>
        /// <param name="name">The name string hold the author name.</param>
        public void setAuthor(string name)
        {
            lblAuthor.Text = name;
        }
        /// <summary>
        /// This function sets the price of the book.
        /// </summary>
        /// <param name="price">The name double hold the price of the book.</param>
        public void setPrice(double price)
        {
            lblPrice.Text = price.ToString() + " TL";
        }
        /// <summary>
        /// This function sets publisher name.
        /// </summary>
        /// <param name="name">The name string hold the publisher name.</param>
        public void setPublisher(string name)
        {
            lblPublisher.Text = name;
        }
        /// <summary>
        /// This function sets the page of the book.
        /// </summary>
        /// <param name="page">The name int hold the page of the book.</param>
        public void setPage(int page)
        {
            lblPage.Text = page.ToString() + " pages";
        }
        /// <summary>
        /// This function returns a value.
        /// </summary>
        public Button getAddButton()
        {
            return btnAddCart;
        }

    }


}