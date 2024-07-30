using library_management_system;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_management__system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student StudentInfo= new Student();
            StudentInfo.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Book bookInfo = new Book();
            bookInfo.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            borrowing1 br= new borrowing1();
            br.Show();                  
        }

        private void button4_Click(object sender, EventArgs e)
        {
           Liberian lb=new Liberian();
            lb.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Environment.ExitCode = 1;
            Application.Exit();
            //this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
