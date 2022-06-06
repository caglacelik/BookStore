using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    /**
    * @brief This file is interface of MusicCD Data Access Layer. Couples systems loosely via abstraction.
    */
    public interface IMusicCDDal
    {
        List<MusicCD> GetAll();

        void getWithId(int id, MusicCD musicCD);
    }
}