using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class Student
    {

        public string Ssn { get; set; }=string.Empty;
        public string Name { get; set; }=string.Empty;
        public int Age {  get; set; }
        public string Addres {  get; set; }=string.Empty ;
        public Student(string ssn="0", string name="No", int age=0, string addres="no")
        {
            Ssn = ssn;
            Name = name;
            Age = age;
            Addres = addres;
        }
        public override string ToString()
        {
            return $"Name : {Name} , SSn : {Ssn}";
        }
       
    }
}
