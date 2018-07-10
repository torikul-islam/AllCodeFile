using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTutorials.Models;


namespace MVCTutorials.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult EmployeeDetails()
        {

            Employee employee = new Employee()
            {
                Id = 101,
                Name= "Torikul",
                Gender= "Male",
                Salary= 12000
            };
            
            return View(employee);
        }
    }
}