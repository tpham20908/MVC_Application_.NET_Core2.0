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
            var records = dbContext.Film.Include(f=>f.FilmActor).ThenInclude(a=>a.Actor).ToList();
            foreach (var record in records)
            {
                System.Console.WriteLine($"Film: {record.Title}");
                var counter = 0;
                foreach (var fa in record.FilmActor) {
                    System.Console.WriteLine($"\tActor #{++counter}: {fa.Actor.FirstName} {fa.Actor.LastName}");
                }
            }
            var city = new City() { CityId = 0, Name = "Redmondito", CountryId = 108 };
            dbContext.Add(city);
            dbContext.SaveChanges();
            */
            var city = dbContext.City.SingleOrDefault(c=>c.CityId == 1002);
            if (city != null) {
                dbContext.Remove(city);
                dbContext.SaveChanges();
            }
        }
    }
}
