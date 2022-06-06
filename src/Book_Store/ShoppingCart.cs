using Book_Store;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    /**   
     * @brief    This class includes shopping cart operations 
     */
    public class ShoppingCart
    {
        Customer customer = CustomerManager.CreateAsSingleton().User;

        /// <summary>
        /// This function returns list of ItemToPurchase objects.
        /// </summary>
        /// <returns> List of ItemToPurchase objects </returns>
        public List<ItemToPurchase> ItemsToPurchase { get; set; }

        private IShoppingCartDal _shoppingCartDal;

        OrderDal _orderDal = new OrderDal();

        /// <summary>
        /// Constractor for ShoppingCart class
        /// </summary>
        /// <param name="shoppingCartDal">This parameter is a object of IShoppingCartDal class</param>
        /// 
        public ShoppingCart(IShoppingCartDal shoppingCartDal)
        {
            _shoppingCartDal = shoppingCartDal;
            ItemsToPurchase = _shoppingCartDal.GetItemsToPurchase(customer.customerID);
        }
        /// <summary>
        /// This function used to add product in item to purchase
        /// </summary>
        /// <param name="item">This parameter is a object of ItemToPurchase class</param>
        /// <returns> This function does not return a value </returns>
        /// 
        public void AddProduct(ItemToPurchase item)
        {
            ItemToPurchase result = ItemsToPurchase.FirstOrDefault(i => i.Product.Id == item.Product.Id);
            if (result == null)
            {
                ItemsToPurchase.Add(item);
                _shoppingCartDal.AddProduct(item, customer.customerID);
            }
            else
            {
                ItemsToPurchase = _shoppingCartDal.GetItemsToPurchase(customer.customerID);
                _shoppingCartDal.UpdateItemToPurchase(result);
            }
        }
        /// <summary>
        /// This function used to remove product in item to purchase
        /// </summary>
        /// <param name="item">This parameter is a object of ItemToPurchase class</param>
        /// <returns> This function does not return a value </returns>
        /// 
        public void RemoveProduct(ItemToPurchase item)
        {
            ItemsToPurchase = _shoppingCartDal.GetItemsToPurchase(customer.customerID);
            ItemToPurchase result = ItemsToPurchase.FirstOrDefault(i => i.Product.Id == item.Product.Id);
            if (result == null)
            {
                return;
            }
            ItemsToPurchase.Remove(result);
            _shoppingCartDal.RemoveProduct(result);
        }
        /// <summary>
        /// This function used to update product information in item to purchase
        /// </summary>
        /// <param name="item">This parameter is a object of ItemToPurchase class</param>
        /// <returns> This function does not return a value </returns>
        /// 
        public void UpdateItemToPurchase(ItemToPurchase item)
        {
            ItemToPurchase result = ItemsToPurchase.FirstOrDefault(i => i.Product.Id == item.Product.Id);
            if (result == null)
            {
                return;
            }

            if (item.Quantity == 0)
            {
                RemoveProduct(item);
                return;
            }

            _shoppingCartDal.UpdateItemToPurchase(item);
        }
        /// <summary>
        /// This function used to print products 
        /// </summary>
        /// <returns>List of ItemsToPurchase</returns>
        /// 
        public List<ItemToPurchase> PrintProducts()
        {
            return ItemsToPurchase;
        }
        /// <summary>
        /// This function used to call order operations and calculate total price
        /// </summary>
        /// <param name="payment">This parameter is a object of Order class</param>
        /// <returns> This function does not return a value </returns>
        public void PlaceOrder(PaymentType payment)
        {
            List<ShoppingCartDetailDTO> details = _shoppingCartDal.GetByCustomerId(customer.customerID);
            double total = 0;
            foreach (var detail in details)
            {
                total += detail.TotalPrice;
            }

            _orderDal.AddOrder(new Order
            {
                paymentType = payment,
                Date = DateTime.Now,
                TotalPrice = total,
                CustomerId = customer.customerID
            });
            _shoppingCartDal.ClearCart(customer.customerID);
        }
        /// <summary>
        /// This function used to cancel order
        /// </summary>
        /// <param name="orderId">This parameter is a orderId which is wanted to cancel order's</param>
        /// <returns> This function does not return a value </returns>
        public void CancelOrder(int orderId)
        {
            _orderDal.DeleteOrder(orderId);
        }
    }
}