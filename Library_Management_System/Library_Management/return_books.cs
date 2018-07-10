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

namespace Library_Management
{
    public partial class return_books : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FRGKU2V;Initial Catalog=library_management_system;Integrated Security=True;Pooling=False");


        public return_books()
        {
            InitializeComponent();
        }

        private void return_books_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

        }

        public void Fill_Grid()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " Select * from issue_books where student_enrollment = '"+txtEnrNo.Text.ToString()+"' And books_return_date = ''";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnSearchbooks_Click(object sender, EventArgs e)
        {
            Fill_Grid();
            dataGridView1.Visible = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel3.Visible = true;
            int i = 0;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " Select * from issue_books where Id= "+ i + "";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach(DataRow dr in dt.Rows)
            {
                lblBookName.Text =dr["books_name"].ToString();
                lblissue.Text = dr["books_issue_date"].ToString();
            }
        }

        private void btnRtnBooks_Click(object sender, EventArgs e)
        {
            int i = 0;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " Update issue_books set books_return_date = '"+dateTimePicker1.Value.ToString()+"' Where Id= '"+i+"' ";
            cmd.ExecuteNonQuery();

            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = " Update books_info set available_qty = available_qty+1 Where books_name= '"+lblBookName.Text+ "' ";
            cmd1.ExecuteNonQuery();


            MessageBox.Show("Return Books SuccessFully");

            panel3.Visible = true;
        }
    }
}
