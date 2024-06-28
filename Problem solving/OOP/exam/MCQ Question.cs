using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class MCQ_Question:Question
    {
        public string[] Answers { get; set; }
        
        public override void Show()
        {
            Console.WriteLine($"{Num} - {Body} ?. ({Mark})");
            Console.WriteLine("---------------------------");
            for ( int i = 0; i < Answers.Length; i++ )
            {
                Console.Write(i+1);
                Console.WriteLine($"- {Answers[i]} ");
            }
            
        }
    }
}
