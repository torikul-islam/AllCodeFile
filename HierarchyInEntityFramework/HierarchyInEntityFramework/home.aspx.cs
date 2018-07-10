using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace HierarchyInEntityFramework
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private DataTable ConvertEmployeesForDisplay(List<Employee> employees)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("FirstName");
            dt.Columns.Add("LastName");
            dt.Columns.Add("Gender");
            dt.Columns.Add("AnuualSalary");
            dt.Columns.Add("HourlyPay");
            dt.Columns.Add("HoursWorked");
            dt.Columns.Add("Type");

            foreach (Employee e in employees)
            {
                DataRow dr = dt.NewRow();
                dr["ID"] = e.ID;
                dr["FirstName"] = e.FirstName;
                dr["LastName"] = e.LastName;
                dr["Gender"] = e.Gender;

                if (e is PermanentEmployee)
                {
                    dr["AnuualSalary"] = ((PermanentEmployee)e).AnuualSalary;
                    dr["Type"] = "Permanent";
                }
                else
                {
                    dr["ID"] = e.ID;
                    dr["FirstName"] = e.FirstName;
                    dr["LastName"] = e.LastName;
                    dr["Gender"] = e.Gender;

                    dr["HourlyPay"] = ((ContactEmployee)e).HourlyPay;
                    dr["HoursWorked"] = ((ContactEmployee)e).HoursWorked;
                    dr["Type"] = "Contract";
                }
                dt.Rows.Add(dr);

            }
            return dt;
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeDbContex employeeDbContex = new EmployeeDbContex();

            switch (RadioButtonList1.SelectedValue)
            {
                case "Permanent":
                    GridView1.DataSource = employeeDbContex.Employees.OfType<PermanentEmployee>().ToList();
                    GridView1.DataBind();
                    break;

                case "Contact":
                    GridView1.DataSource = employeeDbContex.Employees.OfType<ContactEmployee>().ToList();
                    GridView1.DataBind();
                    break;
                default:
                    GridView1.DataSource = ConvertEmployeesForDisplay(employeeDbContex.Employees.ToList());
                    GridView1.DataBind();
                    break;

            }
        }
    }
}