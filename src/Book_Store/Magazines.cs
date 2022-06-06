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
 * @brief   This file includes to magazine functions.
 */
    public partial class MagazineDesign : UserControl
    {
        public MagazineDesign()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This function sets cd name.
        /// </summary>
        /// <param name="name">The name string hold the magazine name.</param>
        public void setBookName(string name)
        {
            lblName.Text = name;
        }
        /// <summary>
        /// This function sets cd name.
        /// </summary>
        /// <param name="price">The name double hold the price of the magazine.</param>
        public void setPrice(double price)
        {
            lblPrice.Text = price.ToString() + " TL";
        }
        /// <summary>
        /// This function sets cd name.
        /// </summary>
        /// <param name="name">The name string hold the issue of the magazine.</param>
        public void setIssue(string name)
        {
            lblIssue.Text = name;
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