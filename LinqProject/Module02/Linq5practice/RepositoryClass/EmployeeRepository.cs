using System;
using System.Collections.Generic;
using System.Text;
using Linq5practice.EntityClass;

namespace Linq5practice.RepositoryClass
{
    public class EmployeeRepository
    {
        public static List<Employee> GetAll() {

            return new List<Employee>
            {
                new Employee(){ ID=1,Name="Tom",Email="Tom@gmail.com"},
                new Employee(){ ID=2,Name="john",Email="john@gmail.com"},
                new Employee(){ ID=3,Name="Mark",Email="Mark@gmail.com"},
                new Employee(){ ID=4,Name="kim",Email="kim@gmail.com"},
                new Employee(){ ID=5,Name="Adam",Email="Adam@gmail.com"},
            };
        
        }

        

    }
}
