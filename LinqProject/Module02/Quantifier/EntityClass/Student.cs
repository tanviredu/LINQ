using System;
using System.Collections.Generic;
using System.Text;

namespace Quantifier.EntityClass
{
    public class Student
    {
        public string Name {get;set;}
        public int Mark { get; set; }
        public List<Subject> Subjects { get; set; }
    }
}
