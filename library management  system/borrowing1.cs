using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace library_management_system
{
    public partial class borrowing1 : Form
    {
        private readonly string connectionString = @"data source=moha;initial catalog=library;integrated security=true;";

        public borrowing1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("spBorrowBook", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@BorrowID", int.Parse(txtId.Text)); // Replace txtStudentID with your textbox name

                        command.Parameters.AddWithValue("@StudentID", int.Parse(txtStudentId.Text)); // Replace txtStudentID with your textbox name
                        command.Parameters.AddWithValue("@BookID", int.Parse(txtbooks.Text)); // Replace txtBookID with your textbox name
                        command.Parameters.AddWithValue("@BorrowDate", dtbBorrow.Value); // Replace dateTimePickerBorrow with your DateTimePicker
                        command.Parameters.AddWithValue("@DueDate", dtbReturn.Value); // Replace dateTimePickerDue with your DateTimePicker

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Book borrowed successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}