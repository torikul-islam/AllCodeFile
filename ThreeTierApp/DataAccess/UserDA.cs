using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BussinessObject;
using System.Configuration;

namespace DataAccess
{
    public class UserDA
    {
        public string RegistrationDetails(UserBO objBO)
        {
            
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MYBD"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Userinfo1 Values('"+objBO.Name+"', '"+objBO.Address+"', '"+objBO.EmailId+"','"+objBO.MobileNumber+"')",con);
            string result = cmd.ExecuteNonQuery().ToString();
            return result;
            con.Close();

       }


    }
}
