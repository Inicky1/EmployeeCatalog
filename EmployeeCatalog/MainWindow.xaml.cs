using EmployeeCatalog.Models;
using EmployeeCatalog.Views;
using EmployeeCatalog.Views.Elements;
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


namespace EmployeeCatalog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private EmployeeList employeeList;
        public MainWindow()
        {
            InitializeComponent();

            EmployeeBook.Instance.mainWindow = this;

            var grid = FindName("Grid") as Grid;

            employeeList = new EmployeeList();
            grid?.Children.Add(employeeList);
        }

        public void UpdateEmployeeList()
        {
            var grid = FindName("Grid") as Grid;
            grid?.Children.Remove(employeeList);

            employeeList = new EmployeeList();
            grid?.Children.Add(employeeList);
        }
    }
}
