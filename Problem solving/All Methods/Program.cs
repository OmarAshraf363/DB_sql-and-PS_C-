namespace Problem_Solving
{
    internal class Program
    {
       //first method ==>
        static int CharCount(char c, string str)
        {
            var temp = str.Split(c);
            return temp.Length-1;
        }
        //Create a function that takes two strings and returns either true or false depending on whether they're anagrams or not.
        static bool IsAnagram(string str1 ,string str2)
        {
            int cout = 0;
            for (int i =0;i<str1.Length;i++) 
            {
                for (int j = 0; j < str2.Length; j++)
                {
                    if (str1[i] == str2[j])
                    {
                        cout++;
                        break;
                    }
                }
            }
            if(str1==str2) { return true; }
           else if (cout == str2.Length)
            {
                return true;
            }
            return false;
        }
        //Create a function that takes a string and returns the number of alphanumeric characters that occur more than once.
        static int DuplicateCount(string str)
        {
            int count = 0;
            for(int i = 0;i<str.Length;i++)
            {
                for(int j = i+1;j<str.Length;j++)
                {
                    if (str[i] == str[j])
                    {
                        count++;
                        break;
                    }
                }
            }
            return count;
        }
        //get middle chars
        static void GetMiddle(string str)
        {
            if (str.Length > 2)
            {
                Console.WriteLine($"{str[str.Length / 2 - 1]}{str[str.Length / 2]}");
            }
            else
            {
                Console.WriteLine(str);
            }
        }
        //Given a string, create a function to reverse the case. All lower-cased letters should be upper-cased, and vice versa.
        static string ReverseCase(string str )
        {
            var charctr=str.ToCharArray();
            for (int i =0;i< charctr.Length;i++)
            {
                if (char.IsLower(charctr[i]))
                {
                    charctr[i]= char.ToUpper(charctr[i]);

                }
                else
                {
                    charctr[i] = char.ToLower(charctr[i]);
                }
               

            }
            return new string(charctr);
           
        }
        //Create a function that takes an array of arrays with numbers. Return a new (single) array with the largest numbers of each.
        static void LargestNumbers(int[][] arrs)
        {
            int[] maxs= new int[arrs.Length];
            for (int i=0;i<arrs.Length;i++)
            {
                maxs[i] = arrs[i].Max();
            }
            Console.Write("[ ");
            for (int i=0;i<maxs.Length;i++)
            {
                Console.Write($"{maxs[i]} ");
            }
            Console.Write("]");

        }
       
        static void Main(string[] args)
        {
            #region first method
            //Console.WriteLine(CharCount('o',"omaoooor")); ==> first method
            #endregion

            #region IsAnagram
            // secound methoud
            // Console.WriteLine(IsAnagram("omar", "ramo"));==>true 
            // Console.WriteLine(IsAnagram("Nope", "Note"));==>false
            // Console.WriteLine(IsAnagram("cristian","cristina"));==>true
            #endregion

            #region DuplicateCount
            //Console.WriteLine(DuplicateCount("Aa"));
            #endregion

            #region GetMiddle
            //GetMiddle("Aaca");
            #endregion

            #region ReverseCase
            //Console.WriteLine( ReverseCase("Omar"));
            #endregion

            #region LargestNumbers of many Arrays at one time 
            LargestNumbers([[4, 2, 7, 1], [20, 70, 40, 90], [1, 2, 0]]);
            #endregion 
        }
    }
}
