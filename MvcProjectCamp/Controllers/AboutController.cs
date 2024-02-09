﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjectCamp.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        AboutManagerBL abm = new AboutManagerBL(new EfAboutDAL());

        public ActionResult Index()
        {
            return View();
        }
    }
}