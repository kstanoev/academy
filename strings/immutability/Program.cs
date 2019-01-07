using System;

namespace immutability {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine (Object.ReferenceEquals (1, 1));
            Console.WriteLine (Object.ReferenceEquals (false, false));
            Console.WriteLine (Object.ReferenceEquals ("abc", "abc"));
            Console.WriteLine (Object.ReferenceEquals (new Person (), new Person ()));
        }
    }

    class Person {

    }
}