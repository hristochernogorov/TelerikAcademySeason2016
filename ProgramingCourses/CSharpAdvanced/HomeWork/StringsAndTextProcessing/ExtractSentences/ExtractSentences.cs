namespace ExtractSentences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    class ExtractSentences

    {
        private static string result = string.Empty;
        private static string input = string.Empty;
        private static string keyword = string.Empty;

        public static string GetTextWithKeyword(string keyword, string input)
        {
            
            var array = new string[input.Length];
            array = input.Split(new char[] {'.','!','?'}, StringSplitOptions.RemoveEmptyEntries);
            
            foreach (var senquence in array)
            {
                var newArray = new string[senquence.Length];
                newArray = senquence.Split(' ');
                for (int i = 0; i < newArray.Length; i++)
                {

                    if (newArray.Contains(keyword))
                    {
                        Console.Write(senquence + ".");
                        
                    }
                    break;
                }          
            }
            return result;
        }
        static void Main()
        {
            var keyword = Console.ReadLine();
            var input = Console.ReadLine();
            Console.WriteLine(GetTextWithKeyword(keyword, input));
           

        }
    }
}
