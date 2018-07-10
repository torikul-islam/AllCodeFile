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
    public partial class add_books : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FRGKU2V;Initial Catalog=library_management_system;Integrated Security=True;Pooling=False");



        public add_books()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtbookname.Text == "" || txtahorName.Text == "" || txtpublicationName.Text == "" || txtPrice.Text == "" || txtQuartity.Text == "" )
            {
                MessageBox.Show(" All fields Required!. ");
            }
            else
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Insert Into books_info values('" + txtbookname.Text + "', '" + txtahorName.Text + "', '" + txtpublicationName.Text + "', '" + dateTimePicker1.Text + "', " + txtPrice.Text + "," + txtQuartity.Text +", "+ txtQuartity.Text + ")";
                    cmd.ExecuteNonQuery();
                    

                    txtahorName.Text = txtbookname.Text = txtpublicationName.Text  = txtPrice.Text = txtQuartity.Text = string.Empty;
                    MessageBox.Show("Book Save SuccessFully.");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error Occured: " + ex.Message);
                }

                finally
                {
                    con.Close();
                }
            }
        }
    }
}
