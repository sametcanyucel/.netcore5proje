﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        Context c=new Context();
        public void AddCategory(Category category)
        {
            c.Add(category);
            c.SaveChanges();
        }

        public List<Category> GetCategories()
        {
            return c.Categories.ToList();
        }

        public Category GetCategory(int id)
        {
            return c.Categories.Find(id);
        }

        public void RemoveCategory(Category category)
        {
            c.Remove(category);
            c.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            c.Update(category);
            c.SaveChanges();
        }
    }
}
