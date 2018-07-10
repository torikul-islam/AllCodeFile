using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManyTomanyRelationEntityFrameworkCodeFirst
{
    public class Student
    {
        public int StudentID { get; set; }
        public String StudentName { get; set; }
        public IList<Course> Courses { get; set; }
    }
}