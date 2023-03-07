using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository : IBlogDal
    {
        public void Add(Blog entity)
        {
            throw new NotImplementedException();
        }

        public void AddBlog(Blog blog)
        {
            using var db = new Context();
            db.Add(blog);
            db.SaveChanges();
            
        }

        public List<Blog> Blogs()
        {
            using var db = new Context();
            return db.Blogs.ToList();
        }

        public void Delete(Blog entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteBlog(Blog blog)
        {
            using var db = new Context();
            db.Remove(blog);
            db.SaveChanges();
        }

        public List<Blog> GetAll()
        {
            throw new NotImplementedException();
        }

        public Blog GetById(int id)
        {
            using var db = new Context();
            return db.Blogs.Find(id);
            db.SaveChanges();
        }

        public void UpdatE(Blog entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateBlog(Blog blog)
        {
            using var db = new Context();
            db.Update(blog);
            db.SaveChanges();
        }
    }
}
