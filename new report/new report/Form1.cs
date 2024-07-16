using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;

namespace new_report
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=empinfo540;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from empdata1", con);
            con.Open();
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable d = new DataTable("empdata1");
            sd.Fill(d);
            ReportDataSource rd = new ReportDataSource("DataSet1", d);
            reportViewer1.LocalReport.ReportPath = "E:\\mohanraj.dotnet\\new report\\new report\\Report1.rdlc";
            // rv.LocalReport.ReportPath = "C:\\Accord Info Matrix\\DOT NET\\data viewer\\data viewer";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rd);
            reportViewer1.RefreshReport();
        }
    }
}
