using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace user_information
{
    public partial class userinfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=(Localdb)\v11.0;Initial Catalog=userinfo1;Integrated Security=True");
        protected void Button2_Click(object sender, EventArgs e)
        {
            String name = TextBox1.Text;
            int age = int.Parse(TextBox2.Text);
            String location = TextBox3.Text;
            SqlCommand cmd=new SqlCommand("exec addinfo'"+name+"',"+age+",'"+location+"'",con);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            Response.Write((result != 0) ? "Data saved" : "Data not saved");
            con.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           SqlCommand cmd = new SqlCommand("exec getinfo", con);
           con.Open();
           SqlDataAdapter ad=new SqlDataAdapter(cmd);
           DataSet d = new DataSet();
           ad.Fill(d);
           GridView1.DataSource = d;
           GridView1.DataBind();



        }
    }
}