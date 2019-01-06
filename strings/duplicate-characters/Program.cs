using System;

namespace duplicate_characters {
    class Program {
        static void Main (string[] args) {
            Console.Write("input: ");
            string input = Console.ReadLine ();

            // Store encountered letters in this string.
            string table = "";

            // Store the result in this string.
            string result = "";

            // Loop over each character.
            foreach (char value in input) {
                // See if character is in the table.
                if (table.IndexOf (value) == -1) {
                    // Append to the table and the result.
                    table += value;
                    result += value;
                }
            }

            Console.WriteLine("output: " + result);
        }
    }
}