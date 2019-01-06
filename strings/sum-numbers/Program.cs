using System;

namespace sum_numbers {
    class Program {
        static void Main (string[] args) {
            Console.Write ("input: ");
            string[] inputs = Console.ReadLine ().Split (' ');
            int sum = 0;
            foreach (string text in inputs) {
                int numeric_input;
                if (int.TryParse (text, out numeric_input))
                    sum += numeric_input;
            }
            Console.WriteLine ("output: " + sum);
        }
    }
}