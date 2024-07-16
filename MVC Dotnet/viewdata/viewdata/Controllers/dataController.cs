using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace viewdata.Controllers
{
    public class dataController : Controller
    {
        //
        // GET: /data/

        public ActionResult Index()
        {
            ViewData["name"] ="mohan";
            ViewBag.age=23;
            
        }

    }
}
