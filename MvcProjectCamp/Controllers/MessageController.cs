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
    public class MessageController : Controller
    {
        // GET: Message
        MessageManagerBL mm = new MessageManagerBL(new EfMessageDAL());
        MessageValidator messagevalidator = new MessageValidator();
        WriterManagerBL wm = new WriterManagerBL(new EfWriterDAL());
        public ActionResult Inbox(string p)
        {
            var messagelist = mm.GetListInbox(p);
            return View(messagelist);
        }
        public ActionResult Sendbox(string p)
        {
            var messagelist = mm.GetListSendbox(p);
            return View(messagelist);
        }
        public ActionResult GetInBoxMessageDetails(int id)
        {
            var values = mm.GetByID(id);
            values.MessageStatus = true;
            mm.MessageUpdate(values);
            return View(values);
        }
        public ActionResult GetSendBoxMessageDetails(int id)
        {
            var values = mm.GetByID(id);
            values.MessageStatus = true;
            mm.MessageUpdate(values);
            return View(values);
        }
        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }

        [HttpPost]
    }
}