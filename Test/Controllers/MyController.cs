﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test.Controllers
{
    public class MyController : Controller
    {
        //
        // GET: /My/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult IndexUI()
        {
            return View();
        }
        public string GetDate()
        {
            return DateTime.Now.ToString();
        }


        public ActionResult Time()
        {
            return View();
        }
        public ActionResult Rain()
        {
            return View();
        }

        public ActionResult Fire()
        {
            return View();
        }
    }
}
