using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace LoadXMLDataTOSQLServerUsingSQLBULKCOPY
{
    public partial class BulkCopyClass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString.ToString());
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(Server.MapPath("~/Data.xml"));
            DataTable tableDept = dataSet.Tables["Department"];
            con.Open();
            using (SqlBulkCopy objBulkCopy = new SqlBulkCopy(con))
            {
                objBulkCopy.DestinationTableName = "tblDepartment";
                objBulkCopy.ColumnMappings.Add("Id", "Id");
                objBulkCopy.ColumnMappings.Add("Name", "Name");
                objBulkCopy.ColumnMappings.Add("Location", "Location");
                objBulkCopy.WriteToServer(tableDept);
                
            }
            lblMessage.ForeColor = System.Drawing.Color.Green;
            lblMessage.Text = "Data Sent Successfully to Sql Server.";

        }
    }
}