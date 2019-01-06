using System;

namespace unique_string {
    class Program {
        static void Main (string[] args) {
            Console.Write ("input: ");
            string input = Console.ReadLine ();

            bool unique = true;
            for (int i = 0; i < input.Length; i++)
                for (int j = i + 1; j < input.Length; j++)
                    if (input[i] == input[j]) {
                        unique = false;
                        break;
                    }
            Console.WriteLine ($"{input} is {(unique ? "unique" : "not unique")}");
        }
    }
}