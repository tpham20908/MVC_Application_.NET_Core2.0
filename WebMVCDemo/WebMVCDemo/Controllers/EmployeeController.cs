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
        //private EmployeeContext _context;

        //public EmployeeController(EmployeeContext context)
        //{
        //    _context = context;
        //}

        public ActionResult Details(int id)
        {
            EmployeeContext _context = new EmployeeContext();
            Employee employee = _context.Employees.Single(e => e.EmployeeId == id);

            return View(employee);
        }

        public ActionResult Index()
        {
            EmployeeContext _context = new EmployeeContext();
            List<Employee> employees = _context.Employees.ToList();

            return View(employees);
        }
    }
}