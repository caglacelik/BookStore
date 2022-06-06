using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    /**
    * @brief This file is interface of Shopping Cart Data Access Layer. Couples systems loosely via abstraction.
    */
    public interface IShoppingCartDal
    {
        List<ShoppingCartDetailDTO> GetByCustomerId(int customerId);
        void AddProduct(ItemToPurchase item, int customerId);
        void RemoveProduct(ItemToPurchase item);
        void ClearCart(int customerId);
        List<ItemToPurchase> GetItemsToPurchase(int customerId);
        void UpdateItemToPurchase(ItemToPurchase item);
    }
}