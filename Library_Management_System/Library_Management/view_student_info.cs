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
using System.IO;

namespace Library_Management
{
    public partial class view_student_info : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FRGKU2V;Initial Catalog=library_management_system;Integrated Security=True;Pooling=False");

        string pwd = Class1.GetRandomPassword(20);
        string wanted_path;
        DialogResult result;

        public view_student_info()
        {
            InitializeComponent();
        }


        public void viewStudentInfo()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From student_info";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void view_student_info_Load(object sender, EventArgs e)
        {


            viewStudentInfo();

            //Bitmap img;
            //DataGridViewImageColumn imgcol = new DataGridViewImageColumn();
            //imgcol.HeaderText = "Student Image";
            //imgcol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            //imgcol.Width = 100;
            //dataGridView1.Columns.Add(imgcol);

            //foreach ( DataRow dr in dt.Rows)
            //{
            //    img = new Bitmap(@"..\..\" + dr["student_image"].ToString());
            //    dataGridView1.Rows[i].Cells[8].Value = img;
            //    dataGridView1.Rows[i].Height = 100;
            //    i = i+ 1;
            //}



        }

        private void txtSrcStdInfo_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From student_info Where student_name like ( '%"+txtSrcStdInfo.Text+"%' )";
            cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                dataGridView1.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Student Found");
                    
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = 0;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
           // MessageBox.Show(i.ToString());

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " Select * From  student_info Where Id = '" + i + "'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                txtstdname.Text = dr["student_name"].ToString();
                txtEnrollNo.Text = dr["student_entollment_no"].ToString();
                txtDept.Text = dr["student_department"].ToString();
                txtSemi.Text = dr["student_semi"].ToString();
                txtContact.Text = dr["student_contact"].ToString();
                txtEmail.Text = dr["student_email"].ToString();
            }

        }

        private void btnImgUp_Click(object sender, EventArgs e)
        {

            wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
            result = openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "JPEG Files(*.jpeg) | *.jpeg| PNG Files(*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files(*.gif)|*.gif";
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (result == DialogResult.OK)
            {
                int i = 0;
                i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
                File.Copy(openFileDialog1.FileName, wanted_path + "\\student_image\\" + pwd + ".jpg");


                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = " Update student_info set student_name = '"+txtstdname.Text+"', student_image ='"+pwd+"', student_entollment_no = '"+txtEnrollNo.Text+"', student_department= '"+txtDept.Text+"', student_semi= '"+txtSemi.Text+"', student_contact='"+txtDept.Text+"', student_email= '"+txtEmail.Text+"'  Where Id = '" + i + "'";
                cmd.ExecuteNonQuery();
                viewStudentInfo();
                MessageBox.Show("Records Updated Successfully");
                

            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Cancel");
            }
        }
    }
}
