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
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string query = "Insert into Users(Name, Surname, Number) values (@Name, @Surname, @Number)";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Name",txtName.Text);
            cmd.Parameters.AddWithValue("@Surname",txtSurname.Text);
            cmd.Parameters.AddWithValue("@Number", txtNumber.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            GetUser();
            MessageBox.Show("User Added !!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
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
            MessageBox.Show("User Updated !!");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            string query = "DELETE Users Where Id=@Id";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", dgwUsers.CurrentRow.Cells[0].Value);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            GetUser();
            MessageBox.Show("User Deleted !!");
        }
    }
}
