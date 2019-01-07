using System;

namespace alphabet {
    class Program {
        static void Main (string[] args) {
            Console.Write ("input: ");
            string input = Console.ReadLine ();
            foreach (char current in input) {
                Console.WriteLine ($"{current}:{(current - 'a') + 1}");
            }
        }
    }
}