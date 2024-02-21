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
        public ActionResult Headings()
        {
            var headinglist = hm.GetList();
            return View(headinglist);
        }
        public PartialViewResult Index(int id = 0)
        {
            var contentlist = cm.GetListByHeadingID(id);
            return PartialView(contentlist);
        }
    }
}