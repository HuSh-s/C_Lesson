using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone_Contact
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable table;

        private bool Control()
        {
            if (txtName.Text == "" || txtSurname.Text == "" || txtNumber.Text == "")
            {
                MessageBox.Show("Please fill the empty areas !!");
                return false;
            }
            return true;
        }
        //There are 37 people in the phone contacts
        void CountUsers()
        {
            int people = dgwUsers.Rows.Count - 1;
            lblCount.Text = "There are " + people + " people in Phone Contacts";
        }
        void GetUser()
        {
            conn = new SqlConnection(@"server=(localdb)\mssqllocaldb; Initial Catalog = Contacts; Integrated Security = True");
            adapter = new SqlDataAdapter("SELECT * FROM Users", conn);
            table = new DataTable();
            conn.Open();
            adapter.Fill(table);
            dgwUsers.DataSource = table;
            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetUser();
            CountUsers();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Control()) return;

            string query = "Insert into Users(Name, Surname, Number) values (@Name, @Surname, @Number)";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Name",txtName.Text);
            cmd.Parameters.AddWithValue("@Surname",txtSurname.Text);
            cmd.Parameters.AddWithValue("@Number", txtNumber.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            GetUser();
            CountUsers();
            MessageBox.Show(txtName.Text + " " + txtSurname.Text + " Added !!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!Control()) return;

            string query = "Update Users set Name=@Name, Surname=@Surname, Number=@Number Where Id=@Id";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Surname", txtSurname.Text);
            cmd.Parameters.AddWithValue("@Number", txtNumber.Text);
            cmd.Parameters.AddWithValue("@Id", dgwUsers.CurrentRow.Cells[0].Value);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            GetUser();
            CountUsers();
            MessageBox.Show(txtName.Text + " " + txtSurname.Text + " Updated !!");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            string name = dgwUsers.CurrentRow.Cells[1].Value.ToString();
            string surname = dgwUsers.CurrentRow.Cells[2].Value.ToString();

            string query = "DELETE Users Where Id=@Id";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", dgwUsers.CurrentRow.Cells[0].Value);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            GetUser();
            CountUsers();
            MessageBox.Show(name + " " + surname + " Deleted !!");
        }

        private void dgwUsers_CellEnter(Object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgwUsers.CurrentRow.Cells[1].Value.ToString();
            txtSurname.Text = dgwUsers.CurrentRow.Cells[2].Value.ToString();
            txtNumber.Text = dgwUsers.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DataView dv = table.DefaultView;
                dv.RowFilter = "Name Like '" + txtSearch.Text + "%'";
                dgwUsers.DataSource = dv;
            }
            catch(Exception)
            {
                MessageBox.Show("User Not Exist !!");
            }
        }
    }
}
