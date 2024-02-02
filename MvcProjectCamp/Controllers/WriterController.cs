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
    public class WriterController : Controller
    {
        WriterManagerBL wm = new WriterManagerBL(new EfWriterDAL());
        WriterValidator writerValidator = new WriterValidator();

        // GET: Writer
        public ActionResult Index()
        {
            return View();
        }
    }
}