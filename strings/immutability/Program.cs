using System;

namespace immutability {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine (Object.ReferenceEquals (1, 1));
            Console.WriteLine (Object.ReferenceEquals (false, false));
            Console.WriteLine(Object.ReferenceEquals (new Person(), new Person()));
            Console.WriteLine (Object.ReferenceEquals ("", ""));

            // int num1 = 1;
            // int num2 = 1;
            // Console.WriteLine("comparing numbers");
            // Console.WriteLine("  ==: " + (num1 == num2));
            // Console.WriteLine("  Equals: " + num1.Equals(num2));
            // Console.WriteLine ("  ReferenceEquals: " + Object.ReferenceEquals (num1, num2));

            // string str1 = "hello";
            // string str2 = "hello";
            // Console.WriteLine("comparing strings");
            // Console.WriteLine("  ==: " + (str1 == str2));
            // Console.WriteLine("  Equals: " + str1.Equals(str2));
            // Console.WriteLine ("  ReferenceEquals: " + Object.ReferenceEquals (str1, str2));

            // Person person1 = new Person();
            // Person person2 = new Person();
            // Console.WriteLine("comparing classes");
            // Console.WriteLine("  ==: " + (person1 == person2));
            // Console.WriteLine("  Equals: " + person1.Equals(person2));
            // Console.WriteLine ("  ReferenceEquals: " + Object.ReferenceEquals (person1, person2));
        }
    }

    class Person {

    }
}