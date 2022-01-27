using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace EMS.Models
{
    public class EmployeeDbOperation
    {
        private List<Employee> employees;
        public EmployeeDbOperation()
        {
            employees = new List<Employee>();
            //{
            //new Employee() { Id=1,Name="Deepak",Email="abc123@gmail.com",Mobile="95988555454",Gender="Male"},
            //new Employee() { Id=2,Name="Raju",Email="Raju15456456@gmail.com",Mobile="554458785454",Gender="Male"},
            //new Employee() { Id=3,Name="Surat",Email="Surat75545@gmail.com",Mobile="98874542315",Gender="FeMale"},
            //new Employee() { Id=4,Name="Pawan",Email="Pawan65545@gmail.com",Mobile="5548897542321",Gender="Male"}
            //};
        }
        public List<Employee> GetEmployees()
        {
            return this.employees;
        }
        public Employee AddEmployee(Employee obj)
        {
            this.employees.Add(obj);
            return obj;

        }


    }
}