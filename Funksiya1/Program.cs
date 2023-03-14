using System.Runtime.InteropServices;

namespace Yasincode

{
    internal class Program
    {
        static void Main(string[] args) 
        {
            ReverseNumber(123456);
        }
        public static string ReverseNumber(int value)
        {
            string textValue = value.ToString().TrimStart();
            char[] valueChars = textValue.ToCharArray();
            Array.Reverse(valueChars);
            string reversedValue = new string(valueChars);
            Console.WriteLine(reversedValue);
            return reversedValue;
        }
    }
}
