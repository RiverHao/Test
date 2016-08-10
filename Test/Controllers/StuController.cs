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

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult IndexPlane()
        {
            return View();
        }
        public ActionResult Indexcalendar()
        {
            return View("Indexcalendar");
        }
        public ActionResult test1()
        {
            return View("test1");
        }
        public ActionResult BigBlack()
        {
            return View("BigBlack");
        }
        public ActionResult loadpdf()
        {
            return View("View1");
        }
        public ActionResult Img()
        {
            return View("Img");
        }
        public ActionResult UploadImg()
        {
            return View("Img");
        }

    }
}
