using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeCatalog.Models;
using EmployeeCatalog.Views;

namespace EmployeeCatalog.Pages
{
    internal class EmployeeDetailsPage
    {
        private static readonly Lazy<EmployeeDetailsPage> lazy = new Lazy<EmployeeDetailsPage>(() => new EmployeeDetailsPage());

        public static EmployeeDetailsPage Instance => lazy.Value;

        public EmployeeDetail? employeeDetails { get; set; }

        public void updateEmployeeData(Employee employee) => employeeDetails?.updateData(employee);
    }
}
