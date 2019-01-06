using System;

namespace anagrams {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Anagram checker");
            Console.Write ("word #1: ");
            string word1 = Console.ReadLine ();
            Console.Write ("word #2: ");
            string word2 = Console.ReadLine ();

            char[] word1_array = word1.ToCharArray ();
            char[] word2_array = word2.ToCharArray ();

            Array.Sort (word1_array);
            Array.Sort (word2_array);

            bool anagrams = true;

            for (int i = 0; i < Math.Min (word1_array.Length, word2_array.Length); i++) {
                if (word1_array[i] != word2_array[i]) {
                    anagrams = false;
                    break;
                }
            }

            Console.WriteLine($"{word1} and {word2} are {(anagrams ? "" : "not ")}anagrams");
        }
    }
}