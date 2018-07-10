using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ManyToManyRelationEntityFrameWork
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StudentCourseDBContex studentCourseDBContex = new StudentCourseDBContex();
             var ResultQuery =   from studentVar in studentCourseDBContex.Students
                                   from courseVar in studentVar.Courses
                                   select new
                                   {
                                       StudentName = studentVar.StudentName,
                                       CourseName = courseVar.CourseName
                                   };
            GridView1.DataSource = ResultQuery.ToList();

            GridView1.DataBind();
        }
    }
}