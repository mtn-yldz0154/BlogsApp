﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
      public interface IGenericDal<T> where T : class
        
    {
        List<T> GetAll();

        void Add(T entity);

        void UpdatE(T entity);

        void Delete(T entity);

        T GetById(int id);


    }
}
