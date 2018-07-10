using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CachingDataset
{
    public partial class CachingData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLoadData_Click(object sender, EventArgs e)
        {
            if(Cache["Data"] == null)
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString.ToString()))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM tblProductInventory", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    
                    Cache["Data"]= ds;

                    GridView1.DataSource = ds;
                    GridView1.DataBind();
                }
                lblMessage.Text = "Data Load From DataBase.";
            }
            else
            {
                GridView1.DataSource = (DataSet)Cache["Data"];
                GridView1.DataBind();
                lblMessage.Text = "Data Load From Cache.";
            }
              
        }

        protected void btnCache_Click(object sender, EventArgs e)
        {
            if(Cache["Data"] != null)
            {
                Cache.Remove("Data");
                lblMessage.Text = "Data Remove From Cache.";
            }
            else
            {
                lblMessage.Text = "There is Nothing to Remove from Cache.";
            }
        }
    }
}