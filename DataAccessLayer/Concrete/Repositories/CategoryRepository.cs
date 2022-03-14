using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        Context c =new Context();
        DbSet<Category> _Category;

        
        public void Delete(Category p)
        {
           _Category.Remove(p);
            c.SaveChanges();
        }

        public void Insert(Category p)
        {
            _Category.Add(p);
            c.SaveChanges();
        }

        public List<Category> List()
        {
           return _Category.ToList();
        }

        public void Update(Category p)
        {
            c.SaveChanges();
        }
    }
}
