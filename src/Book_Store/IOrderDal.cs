using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    /**
    * @brief This file is interface of Order Data Access Layer. Couples systems loosely via abstraction.
    */
    public interface IOrderDal
    {
        void AddOrder(Order order);
        void DeleteOrder(int orderId);
    }
}