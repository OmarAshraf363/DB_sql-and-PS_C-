using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Torf:MCQ_Question
    {
        public override void Show()
        {
            Console.WriteLine($"{Num} - {Body} ?. ({Mark})");
            Console.WriteLine(" - True");
            Console.WriteLine(" - False");
        }
    }
}
