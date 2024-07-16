using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace viewbag.Controllers
{
    public class bagController : Controller
    {
        //
        // GET: /bag/
       
        public ActionResult Index()
        {
            ViewBag.a = "mohanraj";
            return View();
        }

    }
}
