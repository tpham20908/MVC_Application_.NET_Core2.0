using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contoso.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Contoso.Controllers
{
    public class CustomersController : Controller
    {
        private AdventureWorksContext db = new AdventureWorksContext();

        public IActionResult Index(int num)
        {
            var person = db.Person.FirstOrDefault(p => p.BusinessEntityId == num);

            return View(person);
        }

        public IActionResult PeopleList()
        {
            //var people = db.Person.Where(p => p.BusinessEntityId < 3612 && p.BusinessEntityId > 3493);
            ICollection<Person> people = db.Person.Where(p => p.BusinessEntityId < 3612 && p.BusinessEntityId > 3493).ToList();
            return View(people);
        }

        /*
        public IActionResult CreatePerson()
        {
            Person p = new Person()
            {
                BusinessEntityId = 701,
                Title = "Mr.",
                PersonType = "SC",
                FirstName = "Peter",
                LastName = "Parker"
            };

            db.Person.Add(p);

            db.SaveChanges();

            return RedirectToAction("Index", new { num = 23101 });
        }*/

        public IActionResult UpdatePerson(int BusinessEntityId)
        {
            Person person = db.Person.FirstOrDefault(p => p.BusinessEntityId == BusinessEntityId);
            person.FirstName = "Peter";
            person.LastName = "Parker";
            db.Person.Update(person);
            db.SaveChanges();
            return RedirectToAction("Index", new { num = BusinessEntityId } );
        }
    }
}