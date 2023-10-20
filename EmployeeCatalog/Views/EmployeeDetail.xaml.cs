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

namespace EmployeeCatalog.Views
{
    /// <summary>
    /// Interaction logic for EmployeeDetail.xaml
    /// </summary>
    public partial class EmployeeDetail : UserControl
    {
        private Employee? employee;

        private TextBox firstName;
        private TextBox lastName;
        private TextBox profession;
        private DatePicker startDate;
        private TextBox company;
        public EmployeeDetail()
        {
            InitializeComponent();

            EmployeeDetailsPage.Instance.employeeDetails = this;

            firstName = (TextBox)FindName("eFirstName");
            lastName = (TextBox)FindName("eLastName");
            profession = (TextBox)FindName("eProfession");
            startDate = (DatePicker)FindName("eStartDate");
            company = (TextBox)FindName("eCompany");

        }

        public void updateData(Employee employee)
        {
            this.employee = employee;

            firstName.Text = employee.FirstName;
            lastName.Text = employee.LastName;
            profession.Text = employee.Profession;
            startDate.Text = employee.StartDate.ToString();
            company.Text = employee.Company;
        }
        
        public void saveEmployee(object sender, RoutedEventArgs e)
        {
            if (employee != null)
            {
                employee.FirstName = firstName.Text;
                employee.LastName = lastName.Text;
                employee.Profession = profession.Text;
                employee.StartDate = DateOnly.Parse(startDate.Text);
                employee.Company = company.Text;

                employee = null;
                EmployeeBook.Instance.update();

                firstName.Text = "";
                lastName.Text = "";
                profession.Text = "";
                startDate.Text = "";
                company.Text = "";
            }
        }
    }
}
