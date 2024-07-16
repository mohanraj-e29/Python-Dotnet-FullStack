using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace strong_r_not
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int f = 1, s = 0, n = 121, n1 = n;
            for (int i = 0; i<n;n=n/10)
            {
                f = n % 10;
                for (int j = f-1; j>1; j--)
                {
                    f = f * j;
                }
                s = s + f;

            }
            if (s == n1)
            {
                ric.AppendText("strong" + n1);
            }
            else
            {
                ric.AppendText("not strong" + n1);
            }
        }
    }
}