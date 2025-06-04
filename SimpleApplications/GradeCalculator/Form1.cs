using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int exam1, exam2, exam3, average, passsing_grade;
            exam1 = Convert.ToInt32(txtExam1.Text);
            exam2 = Convert.ToInt32(txtExam2.Text);
            exam3 = Convert.ToInt32(txtExam3.Text);
            passsing_grade = Convert.ToInt32(txtPass.Text);

            average = (exam1 + exam2 + exam3) / 3;

            if (average <= passsing_grade)
            {
                txtResult.Text = average.ToString();
                txtResult.BackColor = Color.Red;
                txtResult.ForeColor = Color.White;
            }
            else
            {
                txtResult.Text = average.ToString();
                txtResult.BackColor = Color.Green;
                txtResult.ForeColor = Color.White;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtExam1.Text = "";
            txtExam2.Text = "";
            txtExam3.Text = "";
            txtResult.Text = "";
            txtPass.Text = "";
            txtResult.BackColor = Color.White;
            txtResult.ForeColor = Color.Black;
        }
    }
}
