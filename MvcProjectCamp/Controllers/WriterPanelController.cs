using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjectCamp.Controllers
{
    public class WriterPanelController : Controller
    {
        // GET: WriterPanel
        // GET: WriterPanel
        HeadingManagerBL hm = new HeadingManagerBL(new EfHeadingDAL());
        CategoryManagerBL cm = new CategoryManagerBL(new EfCategoryDAL());
        WriterManagerBL wm = new WriterManagerBL(new EfWriterDAL());
        WriterValidator writerValidator = new WriterValidator();
        Context c = new Context();

        public ActionResult Index()
        {
            return View();
        }
    }
}