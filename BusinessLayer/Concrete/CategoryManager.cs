using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();

        public List<Category> GetAllBl()
        {
            return repo.List();
        }

        public void InsertCategoryBl(Category p)
        {
            if (p.CategoryName == "" || p.CategoryName.Length < 3 || p.CategoryDescription == ""
                || p.CategoryDescription.Length > 50)
            {
                //hata mesajı
            }
            else
            {
                repo.Insert(p);
            }
        }

        //public void DeleteCategoryBl(Category p) 
        //{
        //    repo.Delete(p); 
        //}




    }
}
