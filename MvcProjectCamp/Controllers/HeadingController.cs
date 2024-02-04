using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjectCamp.Controllers
{
    public class HeadingController : Controller
    {
        // GET: Heading
        HeadingManagerBL hm = new HeadingManagerBL(new EfHeadingDAL());
        CategoryManagerBL cm = new CategoryManagerBL(new EfCategoryDAL());
        WriterManagerBL wm = new WriterManagerBL(new EfWriterDAL());
        public ActionResult Index()
        {
            return View();
        }
    }
}