using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace library_management_system
{
    public partial class returnBook : Form
    {
        private readonly string connectionString = @"data source=moha;initial catalog=library;integrated security=true;"; // Your connection string

        public returnBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("spReturnBook1", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ReturnID", int.Parse(txtRETURN.Text)); // Replace txtBorrowID with your actual textbox name

                        command.Parameters.AddWithValue("@BorrowID", int.Parse(txtBorrowId.Text)); // Replace txtBorrowID with your actual textbox name
                        command.Parameters.AddWithValue("@ReturnDate", DTReturn.Value); // Replace dateTimePickerReturn with your actual DateTimePicker name
                        command.Parameters.AddWithValue("@Condition", cmBookCondition.Text); // Replace txtCondition with your actual textbox name

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Book returned successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void DtBorrow_Click(object sender, EventArgs e)
        {
            // If needed, implement the logic for this event.
        }
    }
}