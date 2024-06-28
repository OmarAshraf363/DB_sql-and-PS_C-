namespace Calc_using_Classs_whithout_creating_ob
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> list = new List<int>();
            list.Add(80);
            list.Add(2);
            list.Add(2);
            Console.WriteLine(Calc.Add(list));
            Console.WriteLine(Calc.Sub(list));
            Console.WriteLine(Calc.Mul(list));
            Console.WriteLine(Calc.Div(list));
        }
    }
}
