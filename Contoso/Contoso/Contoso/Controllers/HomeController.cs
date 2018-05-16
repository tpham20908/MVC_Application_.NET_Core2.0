using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contoso.Models;
using Contoso.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Contoso.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View("IndexWithForm");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(ContactVM contactVm)
        {
            if (ModelState.IsValid)
            {
                Contact contact = new Contact()
                {
                    Id = (int)contactVm.Id,
                    FirstName = contactVm.FirstName,
                    LastName = contactVm.LastName,
                    PhoneNumber = contactVm.PhoneNumber
                };

                Customer customer = new Customer
                {
                    Id = 5,
                    CustomerName = "Startup"
                };

                HomeIndexViewModel vm = new HomeIndexViewModel
                {
                    Contact = contact,
                    Customer = customer

                };

                return View(vm);
            }

            return View("IndexWithForm", contactVm);

        }

        public IActionResult ContactList()
        {
            List<HomeIndexViewModel> contactList = new List<HomeIndexViewModel>();

            int i = 11;
            while (i-- > 0)
            {
                Contact contact = new Contact
                {
                    Id = i,
                    FirstName = "First " + i,
                    LastName = "Last " + i,
                    PhoneNumber = "514-555-931" + i
                };

                Customer customer = new Customer
                {
                    Id = i * 11 + 3,
                    CustomerName = "Customer " + (i * 31 + 54)
                };

                HomeIndexViewModel vm = new HomeIndexViewModel
                {
                    Contact = contact,
                    Customer = customer
                };

                contactList.Add(vm);
            }

            return View(contactList);
        }

        public IActionResult DownloadData()
        {
            //return File("/DownloadData/LetterOfAttendance.pdf", "text/pfd", "important.pdf");
            return PhysicalFile("C:/Users/Minh/Documents/TUNG/Applications/list.txt", "text/plain");
        }
    }
}
