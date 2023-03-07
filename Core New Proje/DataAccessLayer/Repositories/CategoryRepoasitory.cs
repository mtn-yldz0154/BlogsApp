using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepoasitory : ICategoryDal
    {
        Context db=new Context();

        public void Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public void AddBlog(Category entity)
        {
            throw new NotImplementedException();
        }

        public void AddCategory(Category category)
        {
           db.Add(category);
            db.SaveChanges();
        }

        public List<Category> categories()
        {
            return db.categories.ToList();
            db.SaveChanges();
        }

        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteCategory(Category category)
        {
            db.Remove(category);
            db.SaveChanges();
        }

        public List<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            return db.categories.Find(id);
            db.SaveChanges();
        }

        public void UpdatE(Category entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateBlog(Category entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateCategory(Category category)
        {
            db.Update(category);
            db.SaveChanges();
        }
    }
}
