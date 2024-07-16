using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace student_register_form
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=(Localdb)\v11.0;Initial Catalog=stud1;Integrated Security=True");
        protected void Button2_Click(object sender, EventArgs e)
        {
            int sid = int.Parse(TextBox1.Text);
            String sname = TextBox2.Text;
            String sdept = TextBox3.Text;

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@stid";
            p1.SqlDbType = SqlDbType.Int;
            p1.Direction = ParameterDirection.Input;
            p1.Value = sid;

            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@stname";
            p2.SqlDbType = SqlDbType.VarChar;
            p2.Direction = ParameterDirection.Input;
            p2.Size = 25;
            p2.Value = sname;

            SqlParameter p3 = new SqlParameter();
            p3.ParameterName = "@stdept";
            p3.SqlDbType = SqlDbType.VarChar;
            p3.Direction = ParameterDirection.Input;
            p3.Size = 25;
            p3.Value = sdept;
            SqlCommand cmd=new SqlCommand("insert into stdinfo values(@stid,@stname,@stdept)",con);
            con.Open();
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            int result = cmd.ExecuteNonQuery();
            Response.Write((result != 0) ? "Data saved" : "Data not saved");


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int sid = int.Parse(TextBox1.Text);
            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@stid";
            p1.SqlDbType = SqlDbType.Int;
            p1.Direction = ParameterDirection.Input;
            p1.Value = sid;

            SqlParameter p2= new SqlParameter();
            p2.ParameterName = "@stname";
            p2.SqlDbType = SqlDbType.VarChar;
            p2.Direction = ParameterDirection.Output;
            p2.Size= 25;

            SqlParameter p3 = new SqlParameter();
            p3.ParameterName = "@stdept";
            p3.SqlDbType = SqlDbType.VarChar;
            p3.Direction = ParameterDirection.Output;
            p3.Size=25;

            SqlCommand cmd = new SqlCommand("select @stname=sname,@stdept=dept from stdinfo where sid=@stid", con);
            con.Open();
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.ExecuteNonQuery();
            if(p2.Value.ToString()!="")
            {
                TextBox2.Text = p2.Value.ToString();
                TextBox3.Text = p3.Value.ToString();
            }
            else
            {
                Response.Write("Invalid Id");
            }
        }
    }
}