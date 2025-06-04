using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Min_Max_Finder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            int num1, num2, num3, max, min;
            num1 = Convert.ToInt32(txtNum1.Text);
            num2 = Convert.ToInt32(txtNum2.Text);
            num3 = Convert.ToInt32(txtNum3.Text);

            //Find Max
            if (num1 > num2 && num1 > num3)
            {
                max = num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                max = num2;
            }
            else
            {
                max = num3;
            }

            //Find Min
            if (num1 < num2 && num1 < num3)
            {
                min = num1;
            }
            else if (num2 < num1 && num2 < num3)
            {
                min = num2;
            }
            else
            {
                min = num3;
            }

            txtMin.Text = min.ToString();
            txtMax.Text = max.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            txtNum3.Text = "";
            txtMax.Text = "";
            txtMin.Text = "";
        }
    }
}
