using System;
using System.Linq;
using System.Reflection;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Data.DataSet ds;
            System.Net.Http.HttpClient client;

            //to insert a comment press CTRL + K + C
            //to remove a comment press CTRL + K + U
            /* start
             * to write multiline comments 
               end */

            System.Console.WriteLine("***************************\n");
            // loop through the assemblies that this application references
            foreach (var r in Assembly.GetEntryAssembly().GetReferencedAssemblies())
            {
                // load the assembly so we can read its details
                var a = Assembly.Load(new AssemblyName(r.FullName));

                // declare a variable to count the total number of methods
                int methodCount = 0;

                // loop through all the types in the assembly
                foreach(var t in a.DefinedTypes)
                {
                    // add up the counts of methods
                    methodCount += t.GetMethods().Count();
                }
                // output the count of types and their methods
                Console.WriteLine($"{a.DefinedTypes.Count() :N0} types " + $"with {methodCount :N0} methods in {r.Name} assembly.");

            }
            System.Console.WriteLine("***********Naming variables***********\n\n");
            // let the heightInMetres variable become equal to the value 1.88
            double heightInMetres = 1.88;
            Console.WriteLine($"\n\nThe variable {nameof(heightInMetres)} has the value {heightInMetres}.");
            System.Console.WriteLine("************Storing Text***********\n\n");

            char letter = 'A', digit = '1', symbol = '$';
            // char userChoice = GetCharacterFromUser();

            string firstName = "Juliani", lastName = "Schlickmann Damasceno", phoneNumber = "(999) 999-9999";
            // string address = GetAddressFromDatabase(IDisposable: 563);

            string[] variables = { Convert.ToString(letter), Convert.ToString(digit), Convert.ToString(symbol), firstName, lastName, phoneNumber };

            for(int i = 0; i <= (variables.Length - 1); i++)
            {
                System.Console.WriteLine($"Variable name is: {variables[i]} and the content is: {variables[i]}");
            }

            System.Console.WriteLine("************Storing Number***********\n\n");
            uint naturalNumber = 23; // unsigned integer means positive whole number
            int integerNumber = -23; // integer means negative or positive whole number
            double realNumber = 2.3; // double means double-precision floating point

            int decimalNotation = 2_000_000; // 2 million
            int binaryNotation = 0b0001_1110_1000_0100_1000_0000; // 2 million
            int hexadecimalNotation = 0x001E_8480; // 2 million
            Console.WriteLine($"{decimalNotation == binaryNotation}"); // => true
            Console.WriteLine($"{decimalNotation == hexadecimalNotation}"); // => true

        }
    }
}
