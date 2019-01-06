using System;

namespace intro {
    class Program {
        static void Main (string[] args) {
            string str = "Hello World";
            char[] chr = str.ToCharArray ();

            Console.Write ("string: ");
            Console.WriteLine (str);
            Console.Write ("char[]: ");
            Console.WriteLine (chr);

            Console.Write ("string[0]: ");
            Console.WriteLine (str[0]);
            Console.Write ("char[0]: ");
            Console.WriteLine (chr[0]);
        }
    }
}