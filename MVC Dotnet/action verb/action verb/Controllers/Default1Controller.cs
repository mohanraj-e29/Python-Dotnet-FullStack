using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace action_verb.Controllers
{
    public class Default1Controller : Controller
    {
       [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
       public ActionResult Index(emp1 e)
       {
            SqlConnection con= new SqlConnection((@"Data Source=(localdb)\v11.0;Initial Catalog=ram;Integrated Security=True"));
            SqlCommand cmd = new SqlCommand("splog", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add withValue("@eid,e.eid");
            cmd.Parameters.Add WithValue("@eid,e.name");
            con.Open();
            cmd.EndExecuteNonQuery();
            con.Close();
            ViewBag.Data="inserted succesfully";
            return View();

       }
    }
}
