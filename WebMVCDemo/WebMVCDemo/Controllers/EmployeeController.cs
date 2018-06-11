using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVCDemo.Models;

namespace WebMVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Details(int id)
        {
            EmployeeContext _context = new EmployeeContext();
            Employee employee = _context.Employees.Single(e => e.EmployeeId == id);

            return View(employee);
        }
    }
}