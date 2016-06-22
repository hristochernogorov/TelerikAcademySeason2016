namespace StringBuilder
{
    using System;
    using System.Text;

    public static class StringBuilderExtension
    {
        public static StringBuilder MySubstring(this StringBuilder input, int index, int lenght)
        {
            var newString = string.Empty;
            for (int i = index; i < lenght; i++)
            {
                newString += input[i].ToString();
            }

            return new StringBuilder(newString);
        }
    }
}
