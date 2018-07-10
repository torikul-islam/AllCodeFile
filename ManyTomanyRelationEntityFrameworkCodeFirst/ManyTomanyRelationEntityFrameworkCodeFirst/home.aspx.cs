using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManyTomanyRelationEntityFrameworkCodeFirst
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StudentCourseDBContex studentCourseDBContex = new StudentCourseDBContex();
            var q  = from studentvar in studentCourseDBContex.Students
                                   from coursevar in studentvar.Courses
                                   select new
                                   {
                                       StudenName = studentvar.StudentName,
                                       CourseName = coursevar.CourseName

                                   };
            GridView1.DataSource = q.ToList();
            GridView1.DataBind();


        }
    }
}