using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;


namespace TablePerType_TPT_Inheritance_Code_First
{
    [Table("ContractEmployees")]
    public class ContractEmployee : Employee
    {
        public int HoursWorked { get; set; }
        public int HourlyPay { get; set; }
    }
}