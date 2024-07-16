using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace client_side_view_state
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String name = TextBox1.Text;
            ViewState["uname"] = name;
            Response.Write("Data saved");
            TextBox1.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                String n = ViewState["uname"].ToString();
                Response.Write("Good Evening" + n);
            }
            catch(Exception)
            {
                Response.Write("Data not found");
            }
        }
    }
}