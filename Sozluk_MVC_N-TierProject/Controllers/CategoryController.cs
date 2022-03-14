using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sozluk_MVC_N_TierProject.Controllers
{
    public class CategoryController : Controller
    {

        CategoryManager cm = new CategoryManager();
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCategoryList()
        {
            var categoryvalues = cm.GetAllBl();
            return View(categoryvalues);
        }

        [HttpGet]
        public ActionResult AddCategory() { return View(); }


        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
            cm.InsertCategoryBl(p);
            return RedirectToAction("GetCategoryList");
        }


    }
}