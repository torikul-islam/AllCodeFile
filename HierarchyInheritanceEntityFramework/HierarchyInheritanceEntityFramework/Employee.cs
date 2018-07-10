using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HierarchyInheritanceEntityFramework
{
    public class Employee
    {
        [Column(Order =0)]
        public int ID { get; set; }
        [Column(Order = 1)]
        public string FirstName { get; set; }
        [Column(Order = 2)]
        public string LastName { get; set; }
        [Column(Order = 3)]
        public string Gender { get; set; }

    }
}