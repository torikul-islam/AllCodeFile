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
    public partial class issue_books : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FRGKU2V;Initial Catalog=library_management_system;Integrated Security=True;Pooling=False");


        public issue_books()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " Select * From student_info Where student_entollment_no= '"+txtSerchStd.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if(i== 0)
            {
                MessageBox.Show("Enrollment No Found");
                txtstdName.Text = txtStdDept.Text = txtStdSemi.Text = txtStdCont.Text = txtStdEmail.Text = txtBookName.Text = string.Empty;
            }
            else
            {
                foreach (DataRow dr in dt.Rows)
                {
                    txtstdName.Text = dr["student_name"].ToString();
                    txtStdDept.Text = dr["student_department"].ToString();
                    txtStdSemi.Text = dr["student_semi"].ToString();
                    txtStdCont.Text = dr["student_contact"].ToString();
                    txtStdEmail.Text = dr["student_email"].ToString();
                    
                }
            }

        }

        private void issue_books_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        private void txtBookName_KeyUp(object sender, KeyEventArgs e)
        {

            int count = 0;
            if (e.KeyCode != Keys.Enter)
            {
                listBox1.Items.Clear();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * From books_info Where books_name like('%"+txtBookName.Text+"%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                if(count > 0)
                {
                    listBox1.Visible = true;
                    foreach (DataRow dr in dt.Rows)
                    {
                        listBox1.Items.Add(dr["books_name"]);
                    }
                }
                


            }
        }

        private void txtBookName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                listBox1.Focus();
                listBox1.SelectedIndex = 0;
            }
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBookName.Text = listBox1.SelectedItem.ToString();
                listBox1.Visible = false;
            }
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
                txtBookName.Text = listBox1.SelectedItem.ToString();
                listBox1.Visible = false;
           

        }

        private void txtSerchStd_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtSerchStd.Text == string.Empty)
            {
                txtstdName.Text = txtStdDept.Text = txtStdSemi.Text = txtStdCont.Text = txtStdEmail.Text = txtBookName.Text = string.Empty;
            }
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            int books_avail_Qty = 0;
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = " Select * From books_info Where books_name = '"+txtBookName.Text+"' ";
            cmd2.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            da.Fill(dt1);

            foreach (DataRow dr1 in dt1.Rows)
            {
                books_avail_Qty = Convert.ToInt32(dr1["available_qty"].ToString());
            }
      
            if(books_avail_Qty > 0)
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert Into issue_books values('" + txtSerchStd.Text + "','" + txtstdName.Text + "','" + txtStdDept.Text + "','" + txtStdSemi.Text + "','" + txtStdCont.Text + "','" + txtStdEmail.Text + "','" + txtBookName.Text + "','" + dateTimePicker1.Value.ToShortDateString() + "', '')";
                cmd.ExecuteNonQuery();

                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = " Update books_info set available_qty=available_qty-1 Where books_name= '" + txtBookName.Text + "'";
                cmd1.ExecuteNonQuery();
                txtstdName.Text = txtStdDept.Text = txtStdSemi.Text = txtStdCont.Text = txtStdEmail.Text = txtBookName.Text = string.Empty;
                MessageBox.Show("Books Issue SuccessFully");
            }
            else
            {
                MessageBox.Show("Books are not Available");
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
