using System;

namespace substrings {
    class Program {
        static void Main (string[] args) {
            Console.Write("input: ");
            string value = Console.ReadLine();
            for (int length = 1; length < value.Length; length++) {
                for (int start = 0; start <= value.Length - length; start++) {
                    string substring = value.Substring (start, length);
                    Console.WriteLine (substring);
                }
            }
        }
    }
}