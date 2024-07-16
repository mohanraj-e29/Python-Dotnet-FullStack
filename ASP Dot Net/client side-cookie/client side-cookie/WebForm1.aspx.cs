using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace client_side_cookie
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Cookies["uname"].Value = "";
            Response.Cookies["uemail"].Value = "";
            Response.Cookies["uloc"].Value = "";
            Response.Write("data deleted");
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox2.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String name = TextBox1.Text;
            String email = TextBox2.Text;
            String loc = TextBox3.Text;

            HttpCookie ck = new HttpCookie("userinfo");
            Response.Cookies["uname"].Value = name;
            Response.Cookies["uemail"].Value = email;
            Response.Cookies["uloc"].Value = loc;
            Response.Write("Data saved");
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Request.Cookies["uname"].Value != "")
                {
                    TextBox1.Text = Request.Cookies["uname"].Value.ToString();
                    TextBox2.Text = Request.Cookies["uemail"].Value.ToString();
                    TextBox3.Text = Request.Cookies["uloc"].Value.ToString();

                }
                else
                {
                    Response.Write("Data deleted");
                }
            }
            catch(Exception)
            {
                Response.Write("data not found");
            }
        }
    }
}