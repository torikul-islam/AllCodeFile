using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using MVCTotorialsPractice.Models;

namespace MVCTotorialsPractice.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeContex _contex;
        public EmployeeController()
        {
            _contex= new EmployeeContex();
        }

        protected override void Dispose(bool disposing)
        {
            _contex.Dispose();
        }

        // GET: Employee
        public ActionResult Details(int id)
        {

           var employee = _contex.Employees.Single(x => x.EmployeeId == id);
          
            return View(employee);
        }
    }
}