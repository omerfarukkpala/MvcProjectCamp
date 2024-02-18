using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcProjectCamp.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        AdminManagerBL adminManager = new AdminManagerBL(new EfAdminDAL());
        WriterLoginManagerBL wm = new WriterLoginManagerBL(new EfWriterDAL());
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin p)
        {
            Context c = new Context();
            var adminuserinfo = c.Admins.FirstOrDefault(x => x.AdminUserName == p.AdminUserName && x.AdminPassword == p.AdminPassword);
            if (adminuserinfo != null)
            {
                FormsAuthentication.SetAuthCookie(adminuserinfo.AdminUserName, false);
                Session["AdminUserName"] = adminuserinfo.AdminUserName;
                return RedirectToAction("Index", "AdminCategory");
            }
            else
            {
                return RedirectToAction("Index");
            }


            //var response = Request["g-recaptcha-response"];
            //string secretKey = "6LduWsIjAAAAAPPxawMUoGgWOXxY0oVPxKrUwE-d";
            //var client = new WebClient();
            //var reply =
            //client.DownloadString(
            //string.Format("https://www.google.com/recaptcha/api/siteverify?secret={0}&response={1}", secretKey, response));
            //var captchaResponse = JsonConvert.DeserializeObject<CaptchaResponse>(reply);
            //if (!captchaResponse.Success)
            //    TempData["Message"] = "Lütfen güvenliği doğrulayınız.";
            //else
            //{

            //    string encUsername = StaticHash.Encrypt(p.AdminUserName);
            //    string encPassword = StaticHash.Encrypt(p.AdminPassword);
            //    var admin = adminManager.GetAdmin(encUsername, encPassword);

            //    if (admin != null)
            //    {
            //        FormsAuthentication.SetAuthCookie(admin.AdminUserName, false);
            //        Session["AdminUsername"] = admin.AdminUserName;
            //        return RedirectToAction("Index", "AdminCategory");
            //    }
            //}
            //return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult WriterLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult WriterLogin(Writer p)
        {
            Context c = new Context();
            var writeruserinfo = c.Writers.FirstOrDefault(x => x.WriterMail == p.WriterMail && x.WriterPassword == p.WriterPassword);
            //var writeruserinfo = wm.GetWriter(p.WriterMail, p.WriterPassword);
            if (writeruserinfo != null)
            {
                FormsAuthentication.SetAuthCookie(writeruserinfo.WriterMail, false);
                Session["WriterMail"] = writeruserinfo.WriterMail;
                return RedirectToAction("MyContent", "WriterPanelContent");
            }
            else
            {
                return RedirectToAction("WriterLogin");
            }


            //string encUsername = StaticHash.Encrypt(p.WriterMail);
            //string encPassword = StaticHash.Encrypt(p.WriterPassword);
            //var writerUser = wm.GetWriter(encUsername, encPassword);
            //if (writerUser != null)
            //{
            //    FormsAuthentication.SetAuthCookie(writerUser.WriterMail, false);
            //    Session["WriterMail"] = writerUser.WriterMail;
            //    return RedirectToAction("MyContent", "WriterPanelContent");
            //}
            //else
            //{
            //    return RedirectToAction("WriterLogin");
            //}
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Headings", "Default");
        }
    }
}