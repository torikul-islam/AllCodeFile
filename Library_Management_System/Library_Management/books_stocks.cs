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
using System.Net;
using System.Net.Mail;


namespace Library_Management
{
    public partial class books_stocks : Form

    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FRGKU2V;Initial Catalog=library_management_system;Integrated Security=True;Pooling=False");

        public books_stocks()
        {
            InitializeComponent();
        }

        private void books_stocks_Load(object sender, EventArgs e)
        {

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            Fill_Books_info();
        }



        public void Fill_Books_info()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select books_name, books_author_name, books_quantity, available_qty From books_info";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string i;
            i = dataGridView1.SelectedCells[0].Value.ToString();

            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "Select * From issue_books where books_name = '"+i.ToString()+"' AND books_return_date='' ";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select books_name, books_author_name, books_quantity, available_qty From books_info where books_name like ('%" + textBox1.Text+"%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            da1.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnSentEmail_Click(object sender, EventArgs e)
        {
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Credentials = new NetworkCredential("nf85665@gmail.com", "xxxxx");
            smtp.EnableSsl = true;
            MailMessage msg = new MailMessage();
            msg.Subject = "Books Return Notice";
            msg.Body = txtMessasge.Text;
            msg.To.Add(txtEmail.Text);
            msg.From = new MailAddress("Message Sent From <bn896527@gmail.com>");

            try
            {
                smtp.Send(msg);
                MessageBox.Show("Message Sent SuccessFully");
            }
            catch
            {
                throw;
            }
            
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string i;
            i = dataGridView2.SelectedCells[6].Value.ToString();
            txtEmail.Text = i.ToString();
        }
    }

}
