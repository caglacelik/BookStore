using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    /**
    * @brief This file is interface of Book Data Access Layer. Couples systems loosely via abstraction.
    */
    public interface IBookDal
    {
        List<Book> GetAll();
        void getWithId(int id, Book book);
    }
}