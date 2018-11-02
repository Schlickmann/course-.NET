using static System.Console;

namespace Debugging
{
    class Program
    {
        static double Add(double a, double b)
        {
            return a + b; // deliberate bug!
        }

        static void Main(string[] args)
        {
            // In Visual Studio 2017, go to Debug | Start Debugging, or click on the Start toolbar button, or press F5.
            // In Visual Studio Code, go to View | Debug, or press Shift + Cmd + D, and then click on the Start Debugging button, or press F5.
            double a = 4.5; // or use var
            double b = 2.5;
            double answer = Add(a, b);
            WriteLine($"{a} + {b} = {answer}");
            ReadLine(); // wait for user to press ENTER
        }
    }
}
