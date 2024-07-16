using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


namespace aspproject.view.admin
{

    public partial class cars : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(Localdb)\v11.0;Initial Catalog=carent;Integrated Security=True");
        
        protected void Page_Load(object sender, EventArgs e)
        {

           
            
        }

        protected void saveBtn_Click(object sender, EventArgs e)
        {

            try
            {
                if(LnumberTb.Value=="" || BrandTb.Value=="" || ModelTb.Value==""  || PriceTb.Value=="" || ColorTb.Value=="")
                {
                    errormsg.InnerText = "Missing Information";
                }
                else
                {
                    string platenum = LnumberTb.Value;
                    string Brand = BrandTb.Value;
                    string Model = ModelTb.Value;
                    int price = Convert.ToInt32(PriceTb.Value.ToString());
                    string color = ColorTb.Value;
                    string status = AvilableCb.SelectedValue;
                    SqlCommand cmd=new SqlCommand ("insert into cartbl1 values('{0}','{1}','{2}','{3}','{4}','{5}')");
                    con.Open();
                    int result = cmd.ExecuteNonQuery();
                    Response.Write((result != 0) ? "Data Saved.." : "Data Not Saved..");
                    con.Close();
                    

                    errormsg.InnerText = "Car Added";
                }
            }
            catch(Exception)
            {
               // throw;
               errormsg.InnerText ="error";
            }
        }

        
        protected void carlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void printbtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("exec getinfo",con);
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            con.Open();
            DataSet d = new DataSet();
            ad.Fill(d);
            carlist.DataSource = d;
            carlist.DataBind();
        }
    }
}