using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prime_r_not
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            for(int i=1;i<=20;i++)
            {
                int c = 0;
             for(int j=1;j<=i;j++)
             {
                 if(i%j==0)
                 {
                     c++;
                 }
             }
                if(c==2)
                {
                    ri.AppendText("," + i);
                }
            }
        }
    }
}
