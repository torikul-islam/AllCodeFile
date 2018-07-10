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
    public partial class Login : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FRGKU2V;Initial Catalog=library_management_system;Integrated Security=True;Pooling=False");
        int count = 0;




        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from library_person where username= '"+txtUserName.Text+"'  And password = '"+txtPassword.Text+"' ";
            cmd.ExecuteNonQuery();
            
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            count = Convert.ToInt32( dt.Rows.Count.ToString());

            if(count== 0)
            {
                MessageBox.Show("UserName Or password Doesnt match");
            }
            else
            {
                this.Hide();
                mdi_user mu = new mdi_user();
                mu.Show();
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }
    }
}
