using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HierarchyInheritanceEntityFramework
{
    public class ContractEmployee : Employee
    {
        [Column( Order = 5)]
        public int HoursWorked { get; set; }
        [Column(Order = 6)]
        public int HourlyPay { get; set; }
    }
}