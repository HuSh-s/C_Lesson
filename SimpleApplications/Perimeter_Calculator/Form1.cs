using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perimeter_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int longside, shortside, result = 0;
            shortside = Convert.ToInt32(txtShort.Text);
            longside = Convert.ToInt32(txtLong.Text);

            if (rbArea.Checked)
            {
                result = shortside * longside;
            }
            else if (rbPerimeter.Checked)
            { 
                result = 2 * (shortside + longside);
            }
            else
            {
                MessageBox.Show("Please select one option !!");
            }

            lblResult.Text = "Result : " + result;
        }
    }
}
