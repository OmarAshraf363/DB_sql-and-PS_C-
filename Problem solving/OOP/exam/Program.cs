namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Question> questions = new List<Question>()
            {
                new MCQ_Question() {Num = 1,Body="Cr7 is the best",Mark=7,Answers=new string[]{ "ok" , "not","maybe"},corrict=1 },
                new MCQ_Question() {Num = 2,Body="mo is the best",Mark=7,Answers=new string[]{ "ok" , "not","maybe"},corrict=2 },
                new Torf(){Num=3,Body="the ciloe of sun is yellow",Mark=1,Answers=new string[]{"True","false"},corrict=1}
            };
            Utility.ChooseAll(questions);


        }
    }
}
