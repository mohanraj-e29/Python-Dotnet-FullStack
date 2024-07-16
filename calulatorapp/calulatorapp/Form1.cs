using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calulatorapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ec_SelectedIndexChanged(object sender, EventArgs e)
        {
            int first = int.Parse(efn.Text);
            int second = int.Parse(esn.Text);
            string M= ec.Text;
            switch (M)
            {
                case "+":
                    int p = first + second;
                    re.AppendText("" + p);
                    break;
                case "-":
                    int q = first - second;
                    re.AppendText("" + q);
                    break;
                case "*":
                    int r = first * second;
                    re.AppendText("" + r);
                    break;
                case ">":
                    int s = first - second;
                    re.AppendText("" + s);
                    break;
                default:
                    re.AppendText("Invalid");
                    break;
            }






        }
    }
}
