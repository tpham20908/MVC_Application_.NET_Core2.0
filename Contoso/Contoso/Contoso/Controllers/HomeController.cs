using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contoso.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Contoso.Controllers
{
    //[Route("")]
    //[Route("Home")]
    public class HomeController : Controller
    {
        // GET: /<controller>/
        // [Route("")]
        // [Route("Index")]
        // [Route("Index/{id}")]
        public IActionResult Index(int id)
        {
            //return RedirectToAction("index", "memberhome");
            //return RedirectToRoute(new { controller = "memberhome", action = "index" });

            //return LocalRedirect(redirectUrl);
            //return Redirect(redirectUrl);

            
            Contact contact = new Contact
            {
                Id = id,
                FirstName = "Tung",
                LastName = "Pham"
            };

            Customer customer = new Customer
            {
                Id = 5,
                CustomerName = "Startup"
            };

            return View(contact);

            /*
            return Content("<html xmlns=\"http://www.w3.org/1999/xhtml\">" +
                "< head >< title > Home </ title ></ head >< body >Hi there " +
                "@Model.FirstName @Model.LastName! Your Id is @Model.Id</ body >" +
                "</ html > ");
            */
        }

        public IActionResult DownloadData()
        {
            //return File("/DownloadData/LetterOfAttendance.pdf", "text/pfd", "important.pdf");
            return PhysicalFile("C:/Users/Minh/Documents/TUNG/Applications/list.txt", "text/plain");
        }
    }
}
