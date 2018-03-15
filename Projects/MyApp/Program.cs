using System;
using MyApp.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var dbContext = new sakilaContext();
            /*
            var records = dbContext.Film.Include(f => f.FilmActor).ThenInclude(r => r.Actor).ToList();
            foreach (var record in records) 
            {
                Console.WriteLine($"Film: {record.Title}");
                var counter = 1;
                foreach (var fa in record.FilmActor) 
                {
                    Console.WriteLine($"\tActor {counter++}: {fa.Actor.FirstName} {fa.Actor.LastName}");
                }
            }

            var city = new City() 
            {
                CityId = 1001, Name = "Redmond", CountryId = 103 
            };
            dbContext.Add(city);
            dbContext.SaveChanges();
            */
            
            var uTarget = dbContext.City.SingleOrDefault(c => c.CityId == 1001);
            if (uTarget != null) 
            {
                // uTarget.Name = "Kirkland";
                // dbContext.Update(uTarget);
                dbContext.Remove(uTarget);
                dbContext.SaveChanges();
            }
        }
    }
}
