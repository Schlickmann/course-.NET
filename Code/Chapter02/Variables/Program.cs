using System;
using static System.Console;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            object height = 1.88; // storing a double value in an object
            object name = "Amir"; // storing a string value in an object
            // int length1 = name.Length; // gives compile error!
            int length2 = ((string)name).Length; // cast to access members

            // storing a string in a dynamic object
            dynamic anotherName = "Ahmed";
            // this compiles but might throw an exception at run-time!
            int length = anotherName.Length;

            var population = 66_000_000; // 66 million in UK
            var weight = 1.88; // in kilograms
            var price = 4.99M; // in pounds sterling
            var fruit = "Apples"; // strings use double-quotes
            var letter = 'Z'; // chars use single-quotes
            var happy = true; // Booleans have value of true or false

            WriteLine($"{default(int)}"); // 0
            WriteLine($"{default(bool)}"); // False
            WriteLine($"{default(DateTime)}"); // 1/01/0001 00:00:00

            int ICannotBeNull = 4;

            //nullable value type use ? after the type
            int? ICouldBeNull = null;
            WriteLine(ICouldBeNull.GetValueOrDefault()); // 0
            ICouldBeNull = 4;
            WriteLine(ICouldBeNull.GetValueOrDefault()); // 4

            string authorName = null;
            // if authorName is null, instead of throwing an exception,
            // null is returned
            int? howManyLetters = authorName?.Length;

            // result will be three if howManyLetters is null
            var result = howManyLetters ?? 3; //null-coalescing operator (??)
            WriteLine(result);


            Write("Type your first name and press ENTER: ");
            string firstName = ReadLine();
            Write("Type your age and press ENTER: ");
            string age = ReadLine();
            WriteLine($"Hello {firstName}, you look good for {age}.");
        }
    }
}
