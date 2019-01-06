using System;

namespace string_builder {
    class Program {
        static void Main (string[] args) {
            int string_length = 30;
            int iterations = 5000;
            DateTime start_time, end_time;
            int i;
            string text = new String (' ', string_length);
            string result = "";

            // Time string concatenation.
            start_time = DateTime.Now;
            for (i = 0; i < iterations; i++) {
                result += text;
            }
            end_time = DateTime.Now;
            Console.WriteLine ("Concatenation took " + (end_time - start_time).TotalSeconds + " seconds.");

            // Time StringBuilder.
            start_time = DateTime.Now;
            System.Text.StringBuilder sb = new System.Text.StringBuilder (string_length * iterations);
            for (i = 0; i < iterations; i++) {
                sb.Append (text);
            }
            result = sb.ToString ();
            end_time = DateTime.Now;
            Console.WriteLine ("String Builder took " + (end_time - start_time).TotalSeconds);
        }
    }
}