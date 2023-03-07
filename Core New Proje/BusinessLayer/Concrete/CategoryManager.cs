using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
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

        CategoryRepoasitory _categoryRepoasitory;

        public CategoryManager()
        {
            _categoryRepoasitory= new CategoryRepoasitory();
        }


        public void AddCategory(Category category)
        {
            _categoryRepoasitory.AddCategory(category);
        }

        public void DeleteCategory(Category category)
        {
            _categoryRepoasitory.Delete(category);
        }

        public List<Category> GetAllCategories()
        {
            return _categoryRepoasitory.GetAll();
        }

        public Category GetById(int id)
        {
            return _categoryRepoasitory.GetById(id);
        }

        public void UpdateCategory(Category category)
        {
            return _categoryRepoasitory.UpdateCategory(category);
        }
    }
}
