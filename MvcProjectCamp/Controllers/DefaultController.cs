using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjectCamp.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        HeadingManagerBL hm = new HeadingManagerBL(new EfHeadingDAL());
        ContentManagerBL cm = new ContentManagerBL(new EfContentDAL());
        public ActionResult Index()
        {
            return View();
        }
    }
}