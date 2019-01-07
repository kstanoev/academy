using System;

namespace mutability {
    class Program {
        static void Main (string[] args) {
            // Char
            char[] char_array = new char[] { 'a', 'b', 'c', 'd', 'e' };
            Console.WriteLine(char_array);
            char_array[0] = 'z';
            Console.WriteLine(char_array);

            // String
            string str = "abcde";
            Console.WriteLine(str);
            //str[0] = 'g'; <-- INVALID
            str = str.Replace('a', 'z');
            Console.WriteLine(str);
        }
    }
}