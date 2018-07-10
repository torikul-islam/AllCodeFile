using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace SQLCOMMANDBUILDER
{
    public partial class CommandBuilder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLoad_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString.ToString());   
            string query = "Select * from tblProductInventory WHERE ProductID = '" + txtProductId.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();

            ViewState["command"] = query;
            ViewState["dataset"] = ds;

            da.Fill(ds, "tblProductInventory");
            if(ds.Tables["tblProductInventory"].Rows.Count >0)
            {
                DataRow dr = ds.Tables["tblProductInventory"].Rows[0];
                txtProductName.Text = dr["ProductName"].ToString();
                txtProductPrice.Text = dr["ProductPrice"].ToString();
            }
            else
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "No Record Found With Product Id " + txtProductId.Text;
                txtProductName.Text = txtProductPrice.Text = string.Empty;
            }
            
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text != "" && txtProductPrice.Text != "")
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString.ToString());
                SqlDataAdapter da = new SqlDataAdapter((string)ViewState["command"], con);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);

                DataSet ds = (DataSet)ViewState["dataset"];

                if (ds.Tables["tblProductInventory"].Rows.Count > 0)
                {
                    DataRow dr = ds.Tables["tblProductInventory"].Rows[0];
                    dr["ProductName"] = txtProductName.Text;
                    dr["ProductPrice"] = txtProductPrice.Text;
                }

                da.Update(ds, "tblProductInventory");
                lblMessage.ForeColor = System.Drawing.Color.Green;
                lblMessage.Text = "Records Updates Successfully";
                txtProductId.Text = txtProductName.Text = txtProductPrice.Text = string.Empty;
            }

            else
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Please! Load Data First.";
            }
            
           
        }
    }
}