using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace TableSplittingCodeFirstApproach
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private DataTable GetEmployeeDetaisIncludeContactDetails()
        {
            EmployeeDBContex employeeDBContex = new EmployeeDBContex();
            List<Employee> employeesDeials = employeeDBContex.Employees.Include("EmployeeContactDetails").ToList();

            DataTable dt = new DataTable();
            DataColumn[] dataColums = {
                    new DataColumn("EmployeeID"),
                    new DataColumn("FirstName"),
                    new DataColumn("LastName"),
                    new DataColumn("Gender"),
                    new DataColumn("Email"),
                    new DataColumn("Mobile"),
                    new DataColumn("LandLine")
                    };
            dt.Columns.AddRange(dataColums);


            foreach (Employee e in employeesDeials)
            {
                DataRow dr = dt.NewRow();
                dr["EmployeeID"] = e.EmployeeID;
                dr["FirstName"] = e.FirstName;
                dr["LastName"] = e.LastName;
                dr["Gender"] = e.Gender;
                dr["Email"] = e.employeeContactDetails.Email;
                dr["Mobile"] = e.employeeContactDetails.Mobile;
                dr["LandLine"] = e.employeeContactDetails.LandLine;
                dt.Rows.Add(dr);

            }
            return dt;
        }

        private DataTable GetEmployeeDetais()
        {
            EmployeeDBContex employeeDBContex = new EmployeeDBContex();
            List<Employee> employeesDeials = employeeDBContex.Employees.ToList();

            DataTable dt = new DataTable();
            DataColumn[] dataColums = {
                    new DataColumn("EmployeeID"),
                    new DataColumn("FirstName"),
                    new DataColumn("LastName"),
                    new DataColumn("Gender"),
                    
                    };
            dt.Columns.AddRange(dataColums);


            foreach (Employee e in employeesDeials)
            {
                DataRow dr = dt.NewRow();
                dr["EmployeeID"] = e.EmployeeID;
                dr["FirstName"] = e.FirstName;
                dr["LastName"] = e.LastName;
                dr["Gender"] = e.Gender;
                
                dt.Rows.Add(dr);

            }
            return dt;
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
            {
                GridView1.DataSource = GetEmployeeDetaisIncludeContactDetails();
            }
            else
            {
                GridView1.DataSource = GetEmployeeDetais();

            }
            GridView1.DataBind();
        }
    }
}