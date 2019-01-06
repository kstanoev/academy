using System;

namespace palindrome {
    class Program {
        static void Main (string[] args) {
            Console.Write ("input: ");
            string input = Console.ReadLine ();
            bool palindrome = true;
            for (int i = 0, j = input.Length - 1; i <= j; i++, j--) {
                Console.WriteLine ("comparing: " + input[i] + " and " + input[j]);
                if (input[i] != input[j]) {
                    palindrome = false;
                    break;
                }
            }

            Console.WriteLine ($"{input} is {(palindrome ? "a" : "not a")} palindrome");
        }
    }
}