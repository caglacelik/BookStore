using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    /**
    * @brief This file is interface of Magazine Data Access Layer. Couples systems loosely via abstraction.
    */
    public interface IMagazineDal
    {
        List<Magazine> GetAll();
    }
}