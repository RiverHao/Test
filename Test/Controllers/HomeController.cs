using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Baidu()
        {
            ViewBag.data = "百度";
            ViewData["Data"] = "我是Data";
            return View();
        }
        public ActionResult Razor()
        {
            //return Redirect("Stu/index");
            return View();
        }
        public ActionResult Tab()
        {
            //return Redirect("Stu/index");
            return View();
        }

    }
}
