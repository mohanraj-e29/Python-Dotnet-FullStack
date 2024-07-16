using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication2.Models;

namespace MvcApplication2.Controllers
{
    public class bindController : Controller
    {
        public ActionResult Index()
        {
            employee emp = new employee();
            emp.eid = 101;
            emp.name = "sam";
            emp.dept = "it";
            emp.exp = 2;
            ViewBag.data = emp;
            return View();
        }

    }
}
