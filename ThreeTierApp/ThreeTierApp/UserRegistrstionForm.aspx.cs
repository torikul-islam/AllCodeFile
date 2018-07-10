using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bussinesslogic;
using BussinessObject;



namespace ThreeTierApp
{
    public partial class UserRegistrstionForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            UserBO objBO = new UserBO();
            objBO.Name = txtname.Text;
            objBO.Address = txAddress.Text;
            objBO.EmailId = txtEmailid.Text;
            objBO.MobileNumber = txtmobile.Text;

            UserBL objBL = new UserBL();
            objBL.SaveRegistration(objBO);


        }
    }
}