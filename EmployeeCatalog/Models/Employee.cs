using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCatalog.Models
{
    public class Employee
    {
        public Employee(string firstName, string lastName, string profession, DateOnly startDate, string company)
        {
            FirstName = firstName;
            LastName = lastName;
            Profession = profession;
            StartDate = startDate;
            Company = company;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Profession {  get; set; }
        public DateOnly StartDate { get; set; }
        public string Company {  get; set; }

    }
}
