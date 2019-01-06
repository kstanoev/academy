using System;

namespace occurring_character {
    class Program {
        static void Main (string[] args) {
            // Read input
            Console.Write("input: ");
            var input_array = Console.ReadLine().ToCharArray ();
            // Sort using quicksort (https://cdn-images-1.medium.com/max/1200/1*FKql5rhPdskhNAFV2D0RUQ.jpeg)
            Array.Sort (input_array);
            Console.WriteLine ("Highest occurring character: " + input_array[0]);

            // Count number of occurrences
            int occurrences = 1;
            for (int i = 1; i < input_array.Length; i++) {
                if (input_array[i] == input_array[0])
                    occurrences++;
                else
                    break;
            }
            Console.WriteLine ("Number of occurrences: " + occurrences);
        }
    }
}