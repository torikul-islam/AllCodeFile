using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Services;

namespace InserDataUsingAjax
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static string InsertMethod(string Name, string Email)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-BU6CFPS\\SQLEXPRESS;Initial Catalog=PRACTICEDB;Integrated Security=True");
            {
                SqlCommand cmd = new SqlCommand("Insert into AjaxInsert values('" + Name + "', '" + Email + "')", con);
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return "true";
                    
                    
                }
            }
        }

        

        
    }
}
