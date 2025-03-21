﻿using Core.DataAccess.EntityFramework;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EF.MainDB
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, MainDBContext>, ICategoryDal
    {
        public List<Category> GetAll()
        {
            using (var context = new MainDBContext())
            {
                return context.Categories.ToList();
            }
        }
    }
}
