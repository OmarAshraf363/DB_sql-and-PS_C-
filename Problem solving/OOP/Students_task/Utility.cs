using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal static class Utility
    {
       public static void EnterData(ref Student[] students)
        {
            Console.Write("Enter num of Student you want to Add them :");
            int nums=int.Parse(Console.ReadLine());
             students = new Student[nums] ;
            for(int i = 0; i < nums; i++)
            {
                students[i]=new Student();
                if (i == nums-2)
                {
                    Console.WriteLine("Warning...the array neer to complete ==> press to continue");
                    Console.ReadLine();
                    Console.WriteLine($"Name {i + 1} :");
                    students[i].Name = Console.ReadLine();
                    Console.WriteLine($"SSn {i + 1} :");
                    students[i].Ssn = Console.ReadLine();
                    Console.WriteLine($"Age {i + 1} :");
                    students[i].Age = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Address {i + 1} :");
                    students[i].Addres = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"Name {i + 1} :");
                    students[i].Name = Console.ReadLine();
                    Console.WriteLine($"SSn {i + 1} :");
                    students[i].Ssn = Console.ReadLine();
                    Console.WriteLine($"Age {i + 1} :");
                    students[i].Age = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Address {i + 1} :");
                    students[i].Addres = Console.ReadLine();




                }
            }
           
        }
    }
}
