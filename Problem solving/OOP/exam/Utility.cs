using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal static class Utility
    {
        public static void ChooseOnly(Question question)
        {
            question.Show();
            Console.Write("your answer is : ");
            int c=int.Parse(Console.ReadLine());
            if (c == question.corrict)
            {
                Console.WriteLine("your answer is true");
            }
            else
            {
                Console.WriteLine("false");
            }


        }
        public static void ChooseAll(List<Question> questions)
        {
            for(int i = 0; i < questions.Count; i++)
            {
                questions[i].Show();
                Console.Write("your answer is : ");
                int c = int.Parse(Console.ReadLine());
                if (c == questions[i].corrict)
                {
                    Console.WriteLine("your answer is true...press to get next Question"); Console.ReadLine();
                    Console.WriteLine("---------------------------");
                }
                else
                {
                    Console.WriteLine("false");
                    Console.WriteLine("---------------------------");
                }
            }
                
        }
    }
}
