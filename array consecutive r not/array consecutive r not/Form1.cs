using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace array_consecutive_r_not
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            int[] a = { 5,6,7,8,9,10 };
            int c = 0;
            for(int i=0;i<a.Length-1;i++)
            {
              if(a[i]+1== a[i+1])
               {
                    c++; 
               }
            }
            if (c==a.Length-1)
            {
                ri.AppendText(" consective");

            }
            else
            {
                ri.AppendText("Not consective");
            }
       }
    }
}
