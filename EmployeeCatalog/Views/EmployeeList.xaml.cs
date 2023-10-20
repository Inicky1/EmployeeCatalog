using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using EmployeeCatalog.Models;
using EmployeeCatalog.Pages;
using EmployeeCatalog.Views.Elements;

namespace EmployeeCatalog.Views
{
    /// <summary>
    /// Interaction logic for EmployeeList.xaml
    /// </summary>
    public partial class EmployeeList : UserControl
    {
        private StackPanel employeeList;
        public EmployeeList()
        {
            InitializeComponent();

            employeeList = (StackPanel)FindName("Employees");

            var employees = EmployeeBook.Instance.getAll();

            foreach (var employee in employees )
            {
                var employeeElement = new EmployeeListElement(employee);
                employeeList.Children.Add(employeeElement);
            }
        }

        void AddEmployee(object sender, RoutedEventArgs e)
        {
            var employee = new Employee("", "", "", DateOnly.FromDateTime(DateTime.Now), "");

            EmployeeBook.Instance.Add(employee);
            EmployeeDetailsPage.Instance.updateEmployeeData(employee);
        }
    }
}
