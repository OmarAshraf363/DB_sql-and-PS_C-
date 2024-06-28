using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal abstract class Question
    {

        public int Num {  get; set; }
        public string Body { get; set; }=string.Empty;
        public int corrict { get; set; }
        public int Mark { get; set; }

        public Question(int num = 0, string body = "no", int mark = 0, int corrict = 0)
        {
            Num = num;
            Body = body;
            Mark = mark;
            this.corrict = corrict;
        }
        public virtual void Show()
        {
            Console.WriteLine($"{Num} - {Body} ?. ({Mark})");
        }

    }
}
