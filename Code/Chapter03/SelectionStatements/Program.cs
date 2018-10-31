using System;
using static System.Console;
using System.IO;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                WriteLine("There are no arguments.");
            }
            else
            {
                WriteLine("There is at least one argument.");
            }

            WriteLine("**********Pattern matching with the IF statement************\n\n");
            object obj = 3;
            int j = 4;

            if(obj is int i )
            {
                WriteLine($"{i} x {j} = {i * j}\n");
            }
            else
            {
                WriteLine("obj is not an int so it cannot multiply!");
            }

            WriteLine("**********The SWITCH statement************\n\n");
            A_label:
            var number = (new Random()).Next(1, 7);
            WriteLine($"My random number is {number}");
            switch (number)
            {
                case 1:
                    WriteLine("One");
                    break; // jumps to end of switch statement
                case 2:
                    WriteLine("Two");
                    goto case 1;
                case 3:
                case 4:
                    WriteLine("Three or four");
                    goto case 1;
                case 5:
                    // go to sleep for half a second
                    System.Threading.Thread.Sleep(500);
                    goto A_label;
                default:
                    WriteLine("Default");
                    break;
            } // end of switch statement

            WriteLine("**********Pattern matching with the SWITCH statement************\n\n");

            // string path = "/Users/markjprice/Code/Chapter03";
            // macOS
            string path = @"\\vch.ca\home$\HomeDir01\jschlickmanndamascen\Profile\Desktop\C# and .NET course\Code\Chapter03"; // Windows
            Stream s = File.Open( Path.Combine(path, "file.txt"), FileMode.OpenOrCreate);

            switch (s)
            {
                case FileStream writeableFile when s.CanWrite:
                    WriteLine("The stream is to a file that I can write to.");
                    break;
                case FileStream readOnlyFile:
                    WriteLine("The stream is to a read-only file.");
                    break;
                case MemoryStream ms:
                    WriteLine("The stream is to a memory address.");
                    break;
                default: // always evaluated last despite its current position
                    WriteLine("The stream is some other type.");
                    break;
                case null:
                    WriteLine("The stream is null.");
                    break;
            }

            WriteLine("********Casting numbers explicitly**********");
            double c = 9.8;
            int d = (int)c;
            WriteLine(d); // d is 9 losing the .8 part
        }
    }
}
