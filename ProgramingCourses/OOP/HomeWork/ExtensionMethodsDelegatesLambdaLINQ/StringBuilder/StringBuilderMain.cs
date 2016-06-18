namespace StringBuilder
{
    using System;
    using System.Text;

    public class StringBuilderMain
    {
        public static void Main()
        {
            var text = new StringBuilder("OneTwoThree");
            Console.WriteLine(text.MySubstring(0, 3));
        }
    }
}
