using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rotation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] a = { 2, 5, 3, 6, 8, 2, 4 };
            int[] b = new int[10];
            int s = 0;
            int c = int.Parse(etn.Text);
            for (int i = c; i < a.Length; i++)
            {
                b[s] = a[i];
                s++;
            }
            for (int i = 0; i < c; i++)
            {
                b[s] = a[i];
                s++;
            }
            for (int i = 0; i < a.Length; i++)
            {
                ri.AppendText(" , " + b[i]);
            }
        }
    }
}