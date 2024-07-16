using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sessions
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String name = TextBox1.Text;
            String pass = TextBox2.Text;
            Session["uname"] = name;
            Response.Write("Data saved..");
            Session.Timeout = 1;
            TextBox1.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox2.Text = "";
            try
            {
                String n = Session["uname"].ToString();
                if(n!=null)
                {
                    TextBox1.Text = n;
                }
                else
                {
                    Response.Write("Session Time Out");
                }
            }
            catch(Exception)
            {
                Response.Write("Session Time Out..Data destroyed");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            Session.Abandon();
            Response.Write("Logut Success..!");
        }
    }
}