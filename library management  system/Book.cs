using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace library_management__system
{
    public partial class Book : Form
    {
        public Book()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"data source =moha;initial catalog=library;integrated security=true;"))
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("spSaveBook", con);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Id", int.Parse(txtId.Text));
                    command.Parameters.AddWithValue("@Book", txtBook.Text);
                    command.Parameters.AddWithValue("@number", int.Parse(txtNumber.Text));
                    command.Parameters.AddWithValue("@Author", txtauthor.Text);
                    command.Parameters.AddWithValue("@Publisher", txtpublisher.Text);


                    command.ExecuteNonQuery();
                    MessageBox.Show("BOOK saved");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"data source =moha;initial catalog=library;integrated security=true;"))
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("spUpdateBook", con);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Id", int.Parse(txtId.Text));
                    command.Parameters.AddWithValue("@Book", txtBook.Text);
                    command.Parameters.AddWithValue("@number", int.Parse(txtNumber.Text));
                    command.Parameters.AddWithValue("@Author", txtauthor.Text);
                    command.Parameters.AddWithValue("@Publisher", txtpublisher.Text);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Data updated");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"data source =moha;initial catalog=library;integrated security=true;"))
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("spDeleteBook", con);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Id", int.Parse(txtId.Text));


                    command.ExecuteNonQuery();
                    MessageBox.Show("Data deleted");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtauthor.Text == "" || txtBook.Text == "" || txtId.Text == "" || txtNumber.Text == "" || txtpublisher.Text == "")
            {
                MessageBox.Show("fill the bank");
                return;
            }
            SqlConnection con = new SqlConnection(@"data source =moha;initial catalog=library;integrated security=true;");
            SqlCommand command = new SqlCommand("Select * from Books", con);
            SqlDataAdapter da = new SqlDataAdapter(command);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvDisplay.DataSource = dt;
            MessageBox.Show("BOOK ADDED SUCESSFULLY");
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"data source =moha;initial catalog=library;integrated security=true;");
            SqlCommand command = new SqlCommand("Select * from Books", con);
            SqlDataAdapter da = new SqlDataAdapter(command);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvDisplay.DataSource = dt;
        }

        private void dgvDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDisplay_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Book_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"data source =moha;initial catalog=library;integrated security=true;"))
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("display", con);
                    command.CommandType = CommandType.StoredProcedure;



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }

       private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"data source=moha;initial catalog=library;integrated security=true;");
            con.Open();

            // Use parameterized query to prevent SQL Injection
            SqlCommand command = new SqlCommand("spSearchBooks", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@searchText", txtsearch.Text);


            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvDisplay.DataSource = dt;

            con.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"data source =moha;initial catalog=library;integrated security=true;");
            SqlCommand command = new SqlCommand("Select * from books", con);
            SqlDataAdapter da = new SqlDataAdapter(command);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvDisplay.DataSource = dt;
        }
    }
}