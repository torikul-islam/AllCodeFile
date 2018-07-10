using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace InsertValue

{
    public partial class Default : System.Web.UI.Page 
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            String conStr = "Data Source=DESKTOP-BU6CFPS\\SQLEXPRESS;Initial Catalog=PRACTICEDB;Integrated Security=True";
            string cmdStr = "INSERT INTO tbl_Persons (FirstName, LastName, Age, [Date of Birth]) VALUES (@FirstName, @LastName,@Age, @DateofBirth)";
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand(cmdStr, con);
            cmd.Parameters.AddWithValue("@FirstName", txtFastName.Text);
            cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
            cmd.Parameters.AddWithValue("@Age", txtAge.Text);
            cmd.Parameters.AddWithValue("@DateofBirth", txtDOB.Text.ToString());

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Response.Write("<script> alert ('Data Inserted Successfully.') </Script>");
                txtFastName.Text = txtLastName.Text = txtAge.Text = txtDOB.Text = string.Empty;
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }

        }
    }
}