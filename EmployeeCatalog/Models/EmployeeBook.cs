using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCatalog.Models;
class EmployeeBook
{
    private readonly List<Employee> employees;

    private static readonly Lazy<EmployeeBook> lazy = new Lazy<EmployeeBook>(() => new EmployeeBook());

    public static EmployeeBook Instance => lazy.Value;

    public MainWindow? mainWindow { get; set; }


    public EmployeeBook() => employees = new();

    public void Add(Employee employee)
    {
        employees.Insert(0, employee);
        mainWindow?.UpdateEmployeeList();
    }

    public void update()
    {
        mainWindow?.UpdateEmployeeList();
    }

    public List<Employee> getAll() => employees;
}
