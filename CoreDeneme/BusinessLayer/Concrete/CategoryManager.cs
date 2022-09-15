using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EfCategoryRepository categoryRepository;
        public CategoryManager()
        {
            categoryRepository = new EfCategoryRepository();
        }
        public void AddCategory(Category category)
        {
            categoryRepository.Insert(category);
        }

        public List<Category> GetCategories()
        {
           return categoryRepository.GetListAll();
        }

        public Category GetCategory(int id)
        {
            return categoryRepository.GetByID(id);
        }

        public void RemoveCategory(Category category)
        {
            categoryRepository.Delete(category);
        }

        public void UpdateCategory(Category category)
        {
            categoryRepository.Update(category);
        }
    }
}
