using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace loan_eligible_check
{
    public partial class loancheck : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Check_Click(object sender, EventArgs e)
        {
            int age = int.Parse(TextBox1.Text);
            if(age>=23)
            {
                Response.Redirect("home.aspx");
            }
            else
            {
                Response.Write("Invalid Age to apply loan min age is 23");
            }
        }
    }
}