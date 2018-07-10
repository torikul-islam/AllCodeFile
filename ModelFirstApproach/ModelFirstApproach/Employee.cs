using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema; // Contains ForeignKey  Relationship

namespace ModelFirstApproach
{
    public class Employee
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Gender { get; set; }
        public int Salary { get; set; }
        public int DepartmentId { get; set; }

        [ForeignKey("DepartmentId")] // Chanmge column name after create...
        public Department Department { get; set; }
        public string JobTitle { get; set; }
    }
}