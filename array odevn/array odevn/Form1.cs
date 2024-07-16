using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace array_odevn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,11,12,13, 14, 15, 16};
        private void label2_Click(object sender, EventArgs e)
        {
            int sumo = 0, sume = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if ((a[i] % 2) == 1)
                    sumo = sumo + a[i];
            }
            son.AppendText(sumo + "\n");
            for (int j = 1; j < a.Length; j++)
            {
                if ((a[j] % 2) == 0)
                    sume = sume + a[j];
            }
            sen.AppendText(sume + "\n");
        }

        private void son_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void sen_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
