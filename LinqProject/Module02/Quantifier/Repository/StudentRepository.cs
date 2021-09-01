using System;
using System.Collections.Generic;
using System.Text;
using Quantifier.EntityClass;

namespace Quantifier.Repository
{
    public class StudentRepository
    {
        // write a method that will return 
        // all the Student

        public static  List<Student> GetAll() {
            return new List<Student>()
            {
                new Student{ Name="Kim",Mark=90,Subjects = new List<Subject>{
                new Subject(){ SubjectName="math",SubjectMarks=75},
                new Subject(){ SubjectName="English",SubjectMarks=80},
                new Subject(){ SubjectName="art",SubjectMarks=86},
                new Subject(){ SubjectName="history",SubjectMarks=95}
                
                } },
                new Student{ Name="John",Mark=80,Subjects = new List<Subject>{
                new Subject(){ SubjectName="math",SubjectMarks=75},
                new Subject(){ SubjectName="English",SubjectMarks=80},
                new Subject(){ SubjectName="art",SubjectMarks=86},
                new Subject(){ SubjectName="history",SubjectMarks=91}

                }},
                new Student{ Name="Lee",Mark=75,Subjects = new List<Subject>{
                new Subject(){ SubjectName="math",SubjectMarks=89},
                new Subject(){ SubjectName="English",SubjectMarks=90},
                new Subject(){ SubjectName="art",SubjectMarks=90},
                new Subject(){ SubjectName="history",SubjectMarks=91}

                }},
                new Student{ Name="Adam",Mark=60,Subjects = new List<Subject>{
                new Subject(){ SubjectName="math",SubjectMarks=75},
                new Subject(){ SubjectName="English",SubjectMarks=80},
                new Subject(){ SubjectName="art",SubjectMarks=60},
                new Subject(){ SubjectName="history",SubjectMarks=91}

                }}
            };
        }
    }
}
