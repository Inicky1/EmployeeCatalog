using EmployeeCatalog.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace EmployeeCatalog
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var employeeBook = EmployeeBook.Instance;

            employeeBook.Add(new Employee("Mark", "Smith1", "Senior developer at Microsoft / 13 years of Experience", DateOnly.FromDateTime(DateTime.Now), "Microsoft"));
            employeeBook.Add(new Employee("Mark", "Smith2", "Senior developer at Microsoft / 13 years of Experience", DateOnly.FromDateTime(DateTime.Now), "Microsoft"));
            employeeBook.Add(new Employee("Mark", "Smith3", "Senior developer at Microsoft / 13 years of Experience", DateOnly.FromDateTime(DateTime.Now), "Microsoft"));
            employeeBook.Add(new Employee("Mark", "Smith4", "Senior developer at Microsoft / 13 years of Experience", DateOnly.FromDateTime(DateTime.Now), "Microsoft"));

        }
    }
}
