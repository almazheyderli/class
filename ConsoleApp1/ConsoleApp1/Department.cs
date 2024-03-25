using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Department
    {
        Employee[] Employees;
        public void AddEmployee(Employee employee)
        {
            Array.Resize(ref Employees, Employees.Length + 1);
        }
        public void ShowEmployeeInfo()
        {
            for(int i = 0; i < Employees.Length; i++)
            {
                Employee employee = Employees[i];
                Console.WriteLine($"{employee.Name},{employee.Surname},{employee.Age},{employee.DepartmentNo},{employee.Salary}");
            }
        }
        public Employee[] GetEmployees()
        {
            return Employees;
        } 
        public Employee[] GetEmployeesBySalary(decimal min, decimal max)
        {
            Employee[] result = new Employee[] { };
            foreach(Employee employee in Employees)
            { 
                if(employee.Salary > min && employee.Salary < max)
                {
                    Array.Resize(ref result,result.Length + 1);
                }
            }
            return result;
        }
    }
}
