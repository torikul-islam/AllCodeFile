using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HierarchyInheritanceEntityFramework
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private DataTable ConvertEmployeesForDisplay(List<Employee> emp)
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("FirstName");
            dt.Columns.Add("LastName");
            dt.Columns.Add("Gender");
            dt.Columns.Add("AnuualSalary");
            dt.Columns.Add("HourlyPay");
            dt.Columns.Add("HoursWorked");
            dt.Columns.Add("Type");

            foreach (Employee e in emp)
            {
                DataRow dr = dt.NewRow();
                dr["Id"] = e.ID;
                dr["FirstName"] = e.FirstName;
                dr["LastName"] = e.LastName;
                dr["Gender"] = e.Gender;

                if (e is PermanentEmployee)
                {
                    dr["AnuualSalary"] = ((PermanentEmployee)e).AnnualSalary;
                    dr["Type"] = "PermanentEmployee";
                }
                else
                {
                    dr["HourlyPay"] = ((ContractEmployee)e).HourlyPay;
                    dr["HoursWorked"] =((ContractEmployee)e).HoursWorked;
                    dr["Type"] = "ContractEmployee";
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }
        

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeDBContex employeeDBContex = new EmployeeDBContex();

            switch (RadioButtonList1.SelectedValue)
            {
                case "Permanent":
                    GridView1.DataSource = employeeDBContex.EmployeesFromDbSET.OfType<PermanentEmployee>().ToList();
                    GridView1.DataBind();
                    break;
                case "Contract":
                    GridView1.DataSource = employeeDBContex.EmployeesFromDbSET.OfType<ContractEmployee>().ToList();
                    GridView1.DataBind();
                    break;
                default:
                    GridView1.DataSource = ConvertEmployeesForDisplay(employeeDBContex.EmployeesFromDbSET.ToList());
                    GridView1.DataBind();
                    break;

            }

        }
    }
}