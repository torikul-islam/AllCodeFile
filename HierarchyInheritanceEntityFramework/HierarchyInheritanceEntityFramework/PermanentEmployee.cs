using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HierarchyInheritanceEntityFramework
{
    public class PermanentEmployee : Employee
    {
        [Column(Order = 4)]
        public int AnnualSalary { get; set; }
    }

}