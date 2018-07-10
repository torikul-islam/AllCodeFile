using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SQLDataReader
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString.ToString()) ;
            SqlCommand cmd = new SqlCommand("Select * from tblProductInventory", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
           
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ProductId");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Original Price");
            dataTable.Columns.Add("Discount Price");

            while(dr.Read())
            {
                DataRow dataRow = dataTable.NewRow();

                double originalPrice = Convert.ToDouble(dr["ProductPrice"]);
                double discountPrice = originalPrice * 0.9;

                dataRow["ProductId"] = dr["ProductID"];
                dataRow["Name"] = dr["ProductName"];
                dataRow["Original Price"] = originalPrice;
                dataRow["Discount Price"] = discountPrice;
                dataTable.Rows.Add(dataRow);
                
            }
            GridView1.DataSource = dataTable;
            GridView1.DataBind();
            con.Close();

              
            
        }
    }
}
