using System;
using System.Linq;
using System.Collections.Generic;
using Linq5practice.EntityClass;
using Linq5practice.RepositoryClass;

namespace Linq5practice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Employees = new List<Employee>();
            Employees = EmployeeRepository.GetAll();
            //var basicQuery = (from emp in Employees select emp).ToList();
            //PrintResult(basicQuery);
            //var basicMethod = Employees.Select(emp => emp).ToList();
            //PrintResult(basicMethod);
            //var onlyid = (from emp in Employees select emp.Name).ToList();
            //foreach (var item in onlyid) {
            //    Console.WriteLine(item);
            //}
            //var onlyidMethod = Employees.Select(emp => emp.Name).ToList();
            //foreach(var item in onlyidMethod)
            //{
            //    Console.WriteLine(item);
            //}

            // adding operation in basic query
            //var basicQuery = (from emp in Employees select emp.ID.ToString());
            //foreach (var item in basicQuery) {
            //   Console.WriteLine(item);

            //}

            /* var selectQuery = (from emp in Employees
                               select new Employee()
                               {
                                   ID = emp.ID,
                                   Email = emp.Email
                               });

            foreach (var item in selectQuery) {
                Console.WriteLine(item.ID);
                Console.WriteLine(item.Email);
            
            }

            

            var selectQuery = (from emp in Employees
                               select new Student()
                               {
                                   StudentId = emp.ID,
                                   FullName = emp.Name,
                                   StEmail = emp.Email

                               });


            foreach (var item in selectQuery) {

                Console.WriteLine(item.StudentId);
                Console.WriteLine(item.FullName);
            }

            
            var selectMethod = Employees.Select(emp => new Student()
            {
                StudentId = emp.ID,
                FullName = emp.Name,
                StEmail = emp.Email


            }).ToList();

            foreach (var item in selectMethod)
            {

                Console.WriteLine(item.StudentId);
                Console.WriteLine(item.FullName);
            }
            */

            //var query1 = Employees.Select((emp, index) => new { index = index, FullName = emp.Name }).ToList() ;
            //var query2 = Employees.Select((emp, index) => new { index = index, Name = emp.Name }).ToList();

            // filtering data in LINQ

            // query
            /* var query = (from emp in Employees
                          where emp.ID == 4
                          select emp).ToList();

             var query2 = (from str in Employees where str.Name.Length > 3 select str).ToList();
             */
            /* foreach (var item in query2) {
                 Console.WriteLine(item);
             }*/

            // method

            /* var method = Employees.Where(emp => emp.ID == 4).ToList();
 */
            /* foreach (var item in query) {
                 Console.WriteLine(item);
             }*/

            /* Console.WriteLine("--------------------");
             foreach (var item in method) {
                 Console.WriteLine(item);

             }*/


            // it will filter based on the datatype

            /*var datasource = new List<object>() { "Adam", "Harry", "Kim", "John", 1, 2, 3, 4, 5 };
            var methodsyntax = datasource.OfType<int>().ToList();
            var querysyntax = (from x in datasource where x is string select x).ToList();
*/
           /* var querySyntax = (from emp in Employees
                               where emp.ID > 2
                               orderby emp.Name
                               select emp).ToList();

            foreach (var x in querySyntax) {
                Console.WriteLine(x.Name);
                Console.WriteLine(x.ID);
            }

            var methodSyntax = Employees.Where(emp => emp.ID > 2).OrderByDescending(emp => emp.Name).ThenBy(emp => emp.Email).ToList();
            foreach (var x in methodSyntax) {
                Console.WriteLine(x.Name);
                Console.WriteLine(x.Email);
            }*/


            // UP TO CLASS 16
            
            Console.ReadLine();

        }

        public static void PrintResult(List<Employee> E) {
            foreach (var item in E) {
                Console.WriteLine("----------------------");
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Email);
                Console.WriteLine("----------------------");
                
            }
        

            
        }
    }
}
