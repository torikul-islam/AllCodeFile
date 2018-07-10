using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using BusinessObjectLayer;
using System.Web.Services;

namespace DataAccessLayer
{
    public class ClsDataAccess
    {
        
        [WebMethod]
        public string RegistrationDetails(BusinessObject objBOL)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MYCON"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_ResgirstraionDetails");
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@Name", objBOL._Name);
                cmd.Parameters.AddWithValue("@Address", objBOL._Address);
                cmd.Parameters.AddWithValue("@EmailID", objBOL._Email);
                cmd.Parameters.AddWithValue("@Mobilenumber", objBOL._MObileNo);
                cmd.Connection = con;
                string Result= cmd.ExecuteNonQuery().ToString();
                return Result;

            }
            catch
            {
                throw;
            }
            finally
            {
                
              con.Close();
                
            }
        }
    }
}
