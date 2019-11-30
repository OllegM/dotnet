using System;
using System.Collections.Generic;

namespace DelegatesLearnProg
{
  class Program
  {
    static void Main(string[] args)
    {
      List<Employee> employees = new List<Employee>(){
          new Employee() {FirstName = "Oleg", LastName = "Michurin", Salary = 500},
          new Employee() {FirstName = "Ken", LastName = "Block", Salary = 2000},
          new Employee() {FirstName = "Piter", LastName = "Parker", Salary = 5000},
          new Employee() {FirstName = "Jeffrey", LastName = "Richter", Salary = 1500}
      };

      var sorter = new BoobleSort();
      sorter.OnSortDone += (sender, args) => Console.WriteLine($"Sorting cycles done: {args.Count}");
      sorter.Sort(employees, EmployeeSorter);

      foreach (var employee in employees)
      {
        Console.WriteLine($"Employee: {employee.FirstName} {employee.LastName}, {employee.Salary}");
      }
    }

    private static bool EmployeeSorter(Employee e1, Employee e2)
    {
      return e1.Salary < e2.Salary ? true : false;
    }
  }
}
