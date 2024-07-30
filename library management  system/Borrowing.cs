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
    public partial class Borrowing : Form
    {
        public Borrowing()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"data source =moha;initial catalog=library;integrated security=true;"))
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("spSaveBorrowing", con);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Id", int.Parse(txtId.Text));
                    command.Parameters.AddWithValue("@studentName", txtName.Text);
                    command.Parameters.AddWithValue("@book", txtbooks.Text);
                    command.Parameters.AddWithValue("@dateBorrow", DateTime.Parse(txtBorrow.Text));
                    command.Parameters.AddWithValue("@dateReturn", DateTime.Parse(txtReturn.Text));


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
            SqlCommand command = new SqlCommand("Select * from borrowing", con);
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
                    SqlCommand command = new SqlCommand("spUpdateBorrowing", con);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Id", int.Parse(txtId.Text));
                    command.Parameters.AddWithValue("@studentName", txtName.Text);
                    command.Parameters.AddWithValue("@book", txtbooks.Text);
                    command.Parameters.AddWithValue("@dateBorrow", DateTime.Parse(txtBorrow.Text));
                    command.Parameters.AddWithValue("@dateReturn", DateTime.Parse(txtReturn.Text));


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
                    SqlCommand command = new SqlCommand("spDeleteBorrowing", con);
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

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"data source =moha;initial catalog=library;integrated security=true;");
            SqlCommand command = new SqlCommand("Select * from borrowing", con);
            SqlDataAdapter da = new SqlDataAdapter(command);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvDisplay.DataSource = dt;

        }

        private void txtBorrow_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtReturn_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}