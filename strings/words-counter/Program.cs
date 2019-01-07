using System;

namespace words_counter {
    class Program {
        static void Main (string[] args) {
            Console.Write ("input: ");
            string input = Console.ReadLine ();

            // Trim whitespace from beginning and end of string
            input = input.Trim ();
            // Ensure there is only one space between each word in the passed string
            while (input.Contains ("  ")) {
                input = input.Replace ("  ", " ");
            }

            // Count the words
            int words_count = input.Split (' ').Length;

            // Print
            Console.WriteLine ($"{input} contains {words_count} words.");
        }
    }
}