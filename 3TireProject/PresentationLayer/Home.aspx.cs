using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessObjectLayer;
using BusinessLayer;


namespace PresentationLayer
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            BusinessObject objBO = new BusinessObject();
            objBO._Name = txtName.Text;
            objBO._Address = txtAddress.Text;
            objBO._Email = txtEmailid.Text;
            objBO._MObileNo = txtMobile.Text;
            clsBusinessLayer objBL = new clsBusinessLayer();

            try
            {
                string FinalResult = objBL.InsertValue(objBO);
                if (FinalResult != null)
                {
                    Response.Write("Data Successfully Inserted!");
                }
                else
                {
                    Response.Write("Eror!");
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                objBO = null;
                objBL = null;
            }
        }

    }
}