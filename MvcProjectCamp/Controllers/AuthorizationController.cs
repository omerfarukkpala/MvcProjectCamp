using EntityLayer.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;

namespace MvcProjectCamp.Controllers
{
    public class AuthorizationController : Controller
    {
        AdminManagerBL adminmanager = new AdminManagerBL(new EfAdminDAL());

        // GET: Authorization
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddAdmin()
        {
            List<SelectListItem> valueAdminRole = new List<SelectListItem>();
            valueAdminRole.Add(new SelectListItem
            {
                Text = "A",
                Value = "A"

            });
            valueAdminRole.Add(new SelectListItem
            {
                Text = "B",
                Value = "B"

            });
            valueAdminRole.Add(new SelectListItem
            {
                Text = "C",
                Value = "C"

            });
            ViewBag.vlc = valueAdminRole;

            return View();
        }
        [HttpPost]
        public ActionResult AddAdmin(Admin p)
        {
            string encUsername = StaticHash.Encrypt(p.AdminUserName);
            string encPassword = StaticHash.Encrypt(p.AdminPassword);
            p.AdminUserName = encUsername;
            p.AdminPassword = encPassword;
            adminmanager.AdminAdd(p);
            return RedirectToAction("AddAdmin");
        }
        [HttpGet]
        public ActionResult EditAdmin(int id)
        {
            List<SelectListItem> valueAdminRole = new List<SelectListItem>();
            valueAdminRole.Add(new SelectListItem
            {
                Text = "A",
                Value = "A"

            });
            valueAdminRole.Add(new SelectListItem
            {
                Text = "B",
                Value = "B"

            });
            valueAdminRole.Add(new SelectListItem
            {
                Text = "C",
                Value = "C"

            });
            ViewBag.vlc = valueAdminRole;

            var adminValue = adminmanager.GetByID(id);
            return View(adminValue);
        }

        [HttpPost]
        public ActionResult EditAdmin(Admin p)
        {
            adminmanager.AdminUpdate(p);
            return RedirectToAction("Index");
        }
    }
}