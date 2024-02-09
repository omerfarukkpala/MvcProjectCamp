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
    public class ContactController : Controller
    {
        // GET: Contact
        ContactManagerBL cm = new ContactManagerBL(new EfContactDAL());
        MessageManagerBL mm = new MessageManagerBL(new EfMessageDAL());
        ContactValidator cv = new ContactValidator();
        public ActionResult Index()
        {
            return View();
        }
    }
}