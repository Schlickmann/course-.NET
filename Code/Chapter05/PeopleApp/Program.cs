using Packt.CS7;
using static System.Console;
using System;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // var person1 = new Person();
            // person1.Name = "Juliani";
            // person1.DateOfBirth = new System.DateTime(1995, 12, 12);
            // person1.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
            // person1.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon |WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
            // WriteLine($"{person1.Name} was born on {person1.DateOfBirth :dddd, d MMMM yyyy} and {person1.Name}'s favorite wonder is {person1.FavoriteAncientWonder}");
            // // p1.BucketList = (WondersOfTheAncientWorld)18;
            // WriteLine($"{person1.Name}'s bucket list is {person1.BucketList}");

            var person2 = new Person {
                Name = "Janete",
                DateOfBirth = new DateTime(1977, 8, 19)
            };

            WriteLine($"{person2.Name} was born on {person2.DateOfBirth :d MMM yy} and is a {Person.Species} from {person2.HomePlanet}");

            person2.Children.Add(new Person { Name = "Juliani" });
            person2.Children.Add(new Person { Name = "Julia" });
            WriteLine(
            $"{person2.Name} has {person2.Children.Count} children:");
            for (int child = 0; child < person2.Children.Count; child++)
            {
            WriteLine($" {person2.Children[child].Name}");
            }

            BankAccount.InterestRate = 0.012M;
            var ba1 = new BankAccount();
            ba1.AccountName = "Mrs. Jones";
            ba1.Balance = 2400;
            WriteLine($"{ba1.AccountName} earned {ba1.Balance * BankAccount.InterestRate:C} interest.");
            var ba2 = new BankAccount();
            ba2.AccountName = "Ms. Gerrier";
            ba2.Balance = 98;
            WriteLine($"{ba2.AccountName} earned {ba2.Balance * BankAccount.InterestRate:C} interest.");


            var p3 = new Person();
            WriteLine($"{p3.Name} was instantiated at {p3.Instantiated:hh:mm:ss} on {p3.Instantiated:dddd, d MMMM yyyy}");

            var p4 = new Person("Aziz");
            WriteLine($"{p4.Name} was instantiated at {p4.Instantiated:hh:mm:ss} on {p4.Instantiated:dddd, d MMMM yyyy}");

            p4.WriteToConsole(); 
            WriteLine(p4.GetOrigin());

            Tuple<string, int> fruit4 = p4.GetFruitCS4();
            WriteLine($"There are {fruit4.Item2} {fruit4.Item1}.");
            (string, int) fruit7 = p4.GetFruitCS7();
            WriteLine($"{fruit7.Item1}, {fruit7.Item2} there are.");

            var fruitNamed = p4.GetNamedFruit();
            WriteLine($"Are there {fruitNamed.Number} {fruitNamed.Name}?");

            var thing1 = ("Neville", 4);
            WriteLine($"{thing1.Item1} has {thing1.Item2} children.");
            var thing2 = (person2.Name, person2.Children.Count);
            WriteLine($"{thing2.Item1} has {thing2.Item2} children.");

            (string fruitName, int fruitNumber) = person2.GetFruitCS7();
            WriteLine($"Deconstructed: {fruitName}, {fruitNumber}");

            WriteLine(person2.SayHello());
            WriteLine(person2.SayHelloTo("Emily"));

            int a = 10;
            int b = 20;
            int c = 30;
            WriteLine($"Before: a = {a}, b = {b}, c = {c}");
            person2.PassingParameters(a, ref b, out c);
            WriteLine($"After: a = {a}, b = {b}, c = {c}");

            // simplified C# 7 syntax for out parameters
            int d = 10;
            int e = 20;
            WriteLine($"Before: d = {d}, e = {e}, f doesn't exist yet!");
            person2.PassingParameters(d, ref e, out int f);
            WriteLine($"After: d = {d}, e = {e}, f = {f}");

            var sam = new Person
            {
                Name = "Sam",
                DateOfBirth = new DateTime(1972, 1, 27)
            };
            WriteLine(sam.Origin);
            WriteLine(sam.Greeting);
            WriteLine(sam.Age);
        }
    }
}
