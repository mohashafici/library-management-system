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

namespace library_management__system
{
    public partial class Liberian : Form
    {
        public Liberian()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"data source =moha;initial catalog=library;integrated security=true;"))
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("spDeleteLibrarian", con);
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

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection(@"data source =moha;initial catalog=library;integrated security=true;"))
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("spUpdateLibrarian", con);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", int.Parse(txtId.Text));
                    command.Parameters.AddWithValue("@Name", txtName.Text);
                    command.Parameters.AddWithValue("@Age", txtAge.Text);
                    command.Parameters.AddWithValue("@Address", txtAddress.Text);



                    command.ExecuteNonQuery();
                    MessageBox.Show("Data updated");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"data source =moha;initial catalog=library;integrated security=true;"))
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("spSaveLibrarian", con);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@ID", int.Parse(txtId.Text));
                    command.Parameters.AddWithValue("@Name", txtName.Text);
                    command.Parameters.AddWithValue("@Age", txtAge.Text);
                    command.Parameters.AddWithValue("@Address", txtAddress.Text);
                    


                    command.ExecuteNonQuery();
                    MessageBox.Show("Data saved");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if(txtAddress.Text=="" || txtName.Text == "" || txtAge.Text == "" || txtId.Text=="")
            {
                MessageBox.Show("fill the blank");
                return;
            }
            SqlConnection con = new SqlConnection(@"data source =moha;initial catalog=library;integrated security=true;");
            SqlCommand command = new SqlCommand("Select * from librarian", con);
            SqlDataAdapter da = new SqlDataAdapter(command);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvDisplay.DataSource = dt;
        }
    }
}
