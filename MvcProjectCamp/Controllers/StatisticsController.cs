using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjectCamp.Controllers
{
    public class StatisticsController : Controller
    {
        // GET: Statistics
        CategoryManagerBL cm = new CategoryManagerBL(new EfCategoryDAL());
        Context db = new Context();
        Statistics stats = new Statistics();
        public ActionResult Index()
        {
            return View();
        }
    }
}