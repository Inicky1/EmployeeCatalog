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

namespace EmployeeCatalog.Views.Elements
{
    /// <summary>
    /// Interaction logic for EmployeeListElement.xaml
    /// </summary>
    public partial class EmployeeListElement : UserControl
    {
        private Employee employee;
        public EmployeeListElement(Employee employee)
        {
            InitializeComponent();

            this.employee = employee;
            var employeeName = (TextBlock)FindName("employeeName");
            var employeeDescription = (TextBlock)FindName("employeeDescription");

            employeeName.Text = employee.FirstName + " " + employee.LastName;
            employeeDescription.Text = employee.Profession;
        }

        public void selectEmployeeDetails(object sender, RoutedEventArgs e)
        {
            EmployeeDetailsPage.Instance.updateEmployeeData(employee);
        }
    }
}
