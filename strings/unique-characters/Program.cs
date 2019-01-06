using System;

namespace unique_characters {
    class Program {
        static void Main (string[] args) {
            Console.Write ("input: ");
            string input = Console.ReadLine ();
            string result = "";
            foreach (char character in input) {
                if (result.IndexOf (character) == -1) {
                    result += character;
                }
            }
            Console.WriteLine ("output: " + result);
        }
    }
}