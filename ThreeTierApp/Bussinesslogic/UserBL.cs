using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccess;
using BussinessObject;

namespace Bussinesslogic
{
    public class UserBL
    {
        public string SaveRegistration(UserBO objBO)
        {
            UserDA objDA = new UserDA();
            return objDA.RegistrationDetails(objBO);
        }
    }
}

