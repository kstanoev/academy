using System;

namespace reverse {
    class Program {
        static void Main (string[] args) {
            Console.Write ("input: ");
            string input = Console.ReadLine ();
            //string result = ReverseString1 (input);
            string result = ReverseString2 (input);
            Console.WriteLine (result);
        }

        // Needs extra array for result
        // Needs to traverse the full array
        public static string ReverseString1 (string str) {
            char[] chars = str.ToCharArray ();
            char[] result = new char[chars.Length];
            for (int i = 0, j = str.Length - 1; i < str.Length; i++, j--) {
                result[i] = chars[j];
            }
            return new string (result);
        }

        // Uses swap method to reverse
        // Needs to traverse only half of the array
        public static string ReverseString2 (string str)
        {
            char[] chars = str.ToCharArray ();
            for (int i = 0, j = str.Length - 1; i <= j; i++, j--)
            {
                chars[i] = str[j];
                chars[j] = str[i];
            }
            return new string (chars);
        }
    }
}