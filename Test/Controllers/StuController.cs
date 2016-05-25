using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test.Controllers
{
    public class StuController : Controller
    {
        //
        // GET: /Stu/

        public ActionResult Index(int id=0)
        {
            ViewBag.Name = id.ToString();
            return View();
        }
        public ActionResult IndexAPI()
        {
            return View();
        }
        public ActionResult Indexcalendar()
        {
            return View("Indexcalendar");
        }

    }
}
