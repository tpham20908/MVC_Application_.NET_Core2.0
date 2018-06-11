using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMVCDemo.Models
{
    [Table("Employees")]
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Display(Name = "First name")]
        public string FirstName { get; set; }
        [Display(Name = "Last name")]
        public string LastName { get; set; }
        public string Title { get; set; }
        [Display(Name = "Title of Courtesy")]
        public string TitleOfCourtesy { get; set; }
        [Display(Name = "Birth day")]
        public DateTime BirthDate { get; set; }
        [Display(Name = "Hired date")]
        public DateTime HireDate { get; set; }
        public string Address { get; set; }
        [Display(Name = "Home phone")]
        public string HomePhone { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        [Display(Name = "Postal code")]
        public string PostalCode { get; set; }
    }
}