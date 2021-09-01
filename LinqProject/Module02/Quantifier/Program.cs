using System;
using System.Linq;
using System.Collections.Generic;
using Quantifier.EntityClass;
using Quantifier.Repository;

namespace Quantifier
{
    class Program
    {
        static void Main(string[] args)
        {
          List<Student> Students = new List<Student>();
           Students = StudentRepository.GetAll();

            /*//*foreach (var student in Students) {
                Console.WriteLine(student.Name+ " " +student.Mark);
            }*//*

            // check if all the students got more then 80
            // remember all the students

            var is_all_greater_80 = Students.All(student => student.Mark > 80);
            // in query syntax
            var q1 = (from student in Students select student).All(x => x.Mark > 80);


            Console.WriteLine(is_all_greater_80);
            Console.WriteLine(q1);
            // check if any student got freater then 80

            var is_any_greater_80 = Students.Any(student => student.Mark > 80);
            var q2 = (from student in Students select student).Any(x => x.Mark > 80);
            Console.WriteLine(is_any_greater_80);
            Console.WriteLine(q2);
*/

            // fetch all the students has all the subject marks greater than 70
            // all the subjects

            var students1 = (from std in Students where std.Subjects.All(x => x.SubjectMarks > 70) select std).ToList();
            var students2 = (from std in Students where std.Subjects.All(x => x.SubjectMarks > 60) select std).ToList();
            var studentsMethod = Students.Where(std => std.Subjects.All(x => x.SubjectMarks > 60)).Select(std => std).ToList();
            var studentsMethod2 = Students.Where(std => std.Subjects.All(x => x.SubjectMarks > 60)).Select(std => std).ToList();
/*
            foreach (var student in studentsMethod) {
                // you are selecting student
                // so you can access the student information
                // and you use the subject from filtering
                Console.WriteLine(student.Name);
                // three person got marks that higher then 60 in All the subject
            }
*/

            // now any operator find all the stuident 
            // to find any subject greater then 60
            // remember Any and All operation returns boolean value
            var studentmethod3 = Students.Where(std => std.Subjects.Any(x => x.SubjectMarks > 60)).Select(std => std).ToList();
            var studentquery3 = (from std in Students where std.Subjects.Any(x => x.SubjectMarks > 60) select std).ToList();
            /*
                        foreach (var student in studentmethod3) {
                            Console.WriteLine(student.Name);

                        }

                        Console.WriteLine("-----------------------");

                        foreach (var student in studentquery3) {
                            Console.WriteLine(student.Name);
                        }
            */
            // based on only marks


            // these are boolean result
            var studentMethod5 = Students.Any(std => std.Mark > 60);
            var studentquery5 = (from std in Students select std).Any(x => x.Mark > 60);
            Console.WriteLine(studentquery5);
            Console.WriteLine(studentMethod5);


            // find the person who have atleast 1 subject got more than 90%
            // using both Method syntax and query syntax

            var studentmethod6 = Students.Where(std => std.Subjects.Any(x => x.SubjectMarks > 90)).Select(std => std).ToList();
            var studentQuery6 = (from std in Students where std.Subjects.Any(x => x.SubjectMarks > 90) select std).ToList();

            /*  foreach (var student in studentmethod6) {

                  Console.WriteLine(student.Name);
              }


      */

            // CONTAINS Operation
            var is_exists_query = (from student in Students select student.Name).Contains("Kim");
            var is_exists_query2 = (from student in Students select student.Name).Contains("Farao");
            var is_method1 = Students.Select(std => std.Name).Contains("Kim");
            var is_method2 = Students.Select(std => std.Name).Contains("Farao");



            Console.ReadLine();

        }
    }
}
