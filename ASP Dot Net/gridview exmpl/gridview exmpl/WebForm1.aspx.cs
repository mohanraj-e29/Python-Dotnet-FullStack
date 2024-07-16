using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace gridview_exmpl
{

    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(Localdb)\v11.0;Initial Catalog=userinfo1;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
      

        protected void grd_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("exec getinfo", con);
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            con.Close();
            grd.DataSource = ds;
            grd.DataBind();
        }
    }
}