namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var stds = new Student[] { };
            
            Utility.EnterData(ref stds);
            for (int i = 0; i < stds.Length; i++) 
            {
                Console.WriteLine(stds[i]);
            }

        }
    }
}
