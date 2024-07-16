using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace connectivity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con=new SqlConnection(@"Data Source=(Localdb)\v11.0;Initial Catalog=bing;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {

        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            string name = n.Text;
            int age = int.Parse(a.Text);
            long phno = long.Parse(ph.Text);
            SqlCommand cmd = new SqlCommand("insert into minu values('" + name + "'," + age + "," + phno + ")", con);
            con.Open();
            int r=cmd.ExecuteNonQuery();
            MessageBox.Show(r!= 0 ? "Data saved" : "data not saved");
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = n.Text;
            int age = int.Parse(a.Text);
            SqlCommand cmd = new SqlCommand("update set minu age="+age+"where name='"+name+"'", con);
            con.Open();
            int r = cmd.ExecuteNonQuery();
            MessageBox.Show(r != 0 ? "Data updated" : "Invalid name");
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = n.Text;
            SqlCommand cmd = new SqlCommand("delete from minu where name='"+name+"'", con);
            con.Open();
            int r = cmd.ExecuteNonQuery();
            MessageBox.Show(r != 0 ? "Data saves" : "data not saved");
            con.Close();
        }

        private void a_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select*from minu", con);
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            res.DataSource = ds.Tables[0];
            con.Close();
        }
    }
}
