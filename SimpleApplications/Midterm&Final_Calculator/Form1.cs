using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm_Final_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double midterm, final, result, bell_curve;

            if(txtMid.Text == "" || txtFinal.Text == "" || txtBell.Text == "")
            {
                MessageBox.Show("Missing İnformation !!");
                return;
            }

            try
            {
                midterm = Convert.ToDouble(txtMid.Text);
                final = Convert.ToDouble(txtFinal.Text);
                bell_curve = Convert.ToDouble(txtBell.Text);

                midterm *= 0.30;
                final *= 0.70;
                result = midterm + final;

                if (result < bell_curve)
                {
                    txtResult.Text = result.ToString();
                    txtResult.BackColor = Color.Red;
                    txtResult.ForeColor = Color.White;
                }
                else
                {
                    txtResult.Text = result.ToString();
                    txtResult.BackColor = Color.Green;
                    txtResult.ForeColor = Color.White;
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Please enter numbers only !!");
                return;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMid.Text = "";
            txtFinal.Text = "";
            txtResult.Text = "";
            txtBell.Text = "";
            txtResult.BackColor = Color.White;
            txtResult.ForeColor = Color.Black;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtResult.ReadOnly = true;
        }
    }
}
