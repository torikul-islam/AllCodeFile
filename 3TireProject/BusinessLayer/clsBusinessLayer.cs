using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjectLayer;
using DataAccessLayer;


namespace BusinessLayer
{
    public class clsBusinessLayer
    {
        public String InsertValue(BusinessObject objBOL)
        {
            ClsDataAccess objDAL = new ClsDataAccess();
            try
            {
                return objDAL.RegistrationDetails(objBOL);
            }
            catch
            {
                throw;
            }
            finally
            {
                objDAL = null;
            }
        }
    }
}
