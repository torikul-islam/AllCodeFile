using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Library_Management
{
    public partial class add_student_info : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FRGKU2V;Initial Catalog=library_management_system;Integrated Security=True;Pooling=False");

        string pwd = Class1.GetRandomPassword(20);
        string wanted_path;

        public add_student_info()
        {
            InitializeComponent();
        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            try
            {
               // string img_path;

                File.Copy(openFileDialog1.FileName, wanted_path + "\\student_image\\" + pwd + ".jpg");
               // img_path = "student_image\\" + pwd + ".jpg";

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert Into student_info values('" + txtStdName.Text + "','"+ pwd + "', '" + txtEnrollNo.Text + "','" + txtDept.Text + "','" + txtSemi.Text + "','" + txtContNo.Text + "','" + txtEmail.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Information Inserted SuccessFully!");
                txtStdName.Text = txtEnrollNo.Text = txtEnrollNo.Text = txtDept.Text = txtSemi.Text = txtContNo.Text = txtEmail.Text = string.Empty;
                pictureBox1.Image = null;
                

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
           //string pwd = Class1.GetRandomPassword(20);
            wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
            DialogResult result = openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "JPEG Files(*.jpeg) | *.jpeg| PNG Files(*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files(*.gif)|*.gif";
            if (result == DialogResult.OK)
            {
                pictureBox1.ImageLocation =openFileDialog1.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                
            }
        }
    }
}
