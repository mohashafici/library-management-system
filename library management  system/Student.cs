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

namespace library_management__system
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"data source =moha;initial catalog=library;integrated security=true;"))
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("spInsertStudent", con);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Id", int.Parse(txtId.Text));
                    command.Parameters.AddWithValue("@studentName", txtName.Text);
                    command.Parameters.AddWithValue("@Age", int.Parse(txtAge.Text));
                    command.Parameters.AddWithValue("@Roll", int.Parse(txtRoll.Text));
                    command.Parameters.AddWithValue("@Phone", txtphone.Text);
                    command.Parameters.AddWithValue("@Email", txtEmail.Text);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Data saved");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"data source =moha;initial catalog=library;integrated security=true;");
            SqlCommand command = new SqlCommand("Select * from student", con);
            SqlDataAdapter da = new SqlDataAdapter(command);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvDisplay.DataSource = dt;

            clarr();
        }
        public void clarr()
        {
            txtId.Clear();
            txtName.Clear();
            txtAge.Clear();
            txtEmail.Clear();
            txtphone.Clear();
            txtRoll.Clear();
        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"data source =moha;initial catalog=library;integrated security=true;");
            SqlCommand command = new SqlCommand("Select * from student", con);
            SqlDataAdapter da = new SqlDataAdapter(command);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvDisplay.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"data source =moha;initial catalog=library;integrated security=true;"))
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("spUpdateStudent", con);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Id", int.Parse(txtId.Text));
                    command.Parameters.AddWithValue("@studentName", txtName.Text);
                    command.Parameters.AddWithValue("@Age", int.Parse(txtAge.Text));
                    command.Parameters.AddWithValue("@Roll", int.Parse(txtRoll.Text));
                    command.Parameters.AddWithValue("@Phone", txtphone.Text);
                    command.Parameters.AddWithValue("@Email", txtEmail.Text);

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
                    SqlCommand command = new SqlCommand("spDeleteStudent", con);
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

        private void Student_Load(object sender, EventArgs e)
        {

        }
    }
}
