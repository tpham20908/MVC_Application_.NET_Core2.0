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

        public IActionResult GetPerson(int num)
        {
            var person = db.Person.FirstOrDefault(p => p.BusinessEntityId == num);
            ViewBag.Title = person.FirstName + " " + person.MiddleName + " " + person.LastName;

            return View(person);
        }

        public IActionResult Index()
        {
            ViewBag.Title = "People list";
            //ViewBag.from = 1341;
            //ViewBag.to = 1489;
            //int from = ViewBag.from;
            //int to = ViewBag.to;
            //var people = db.Person.Where(p => p.BusinessEntityId < 3612 && p.BusinessEntityId > 3493);
            //ICollection<Person> people = db.Person.Where(p => p.BusinessEntityId >= from && p.BusinessEntityId <= to).ToList();
            ICollection<Person> people = db.Person.ToList();
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdatePerson(Person updatedPerson)
        {
            if (ModelState.IsValid)
            {
                Person person = db.Person.FirstOrDefault(p => p.BusinessEntityId == updatedPerson.BusinessEntityId);
                person.FirstName = updatedPerson.FirstName;
                person.MiddleName = updatedPerson.MiddleName;
                person.LastName = updatedPerson.LastName;
                person.Title = updatedPerson.Title;
                db.Person.Update(person);
                db.SaveChanges();
                return RedirectToAction("GetPerson", new { num = updatedPerson.BusinessEntityId });
            }

            return RedirectToAction("GetPerson", updatedPerson);
        }

        public IActionResult DeletePerson(int num)
        {
            Person deletedPerson = db.Person.FirstOrDefault(p => p.BusinessEntityId == num);
            db.Person.Remove(deletedPerson);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}