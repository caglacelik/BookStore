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
   * @brief   This file includes to cd information.
   */
    public partial class CDsDesign : UserControl
    {
        public CDsDesign()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This function sets cd name.
        /// </summary>
        /// <param name="name">The name string hold the cd name.</param>
        public void setCDName(string name)
        {
            lblCDName.Text = name;
        }
        /// <summary>
        /// This function sets the price of the cd.
        /// </summary>
        /// <param name="price">The name double hold the price of the cd.</param>
        public void setPrice(double price)
        {
            lblPrice.Text = price.ToString() + " TL";
        }
        /// <summary>
        /// This function sets cds type.
        /// </summary>
        /// <param name="name">The name string hold the type of the cd.</param>
        public void setType(string name)
        {
            lblType.Text = name;
        }
        /// <summary>
        /// This function sets singers name.
        /// </summary>
        /// <param name="name">The name string hold the singer name.</param>
        public void setSinger(string name)
        {
            lblSinger.Text = name;
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