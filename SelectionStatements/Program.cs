using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var r = new Random();
            var favNumber = r.Next(1, 1000);
            Console.WriteLine("\nWhat number am I thinking of?");

            var userInput = int.Parse(Console.ReadLine());
            
            while(userInput != 0)
            {
                if (userInput < favNumber)
                    Console.WriteLine("too low. Try again!");
                else if (userInput > favNumber)
                    Console.WriteLine("too high. Try again!");
                else 
                { 
                    Console.WriteLine($"{userInput}... ok nevermind");
                    break;
                }
                userInput = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n------\nOK so what is your favorite subject in school?");
            var inSubject = Console.ReadLine();
            var inLower = inSubject.ToLower();

            switch(inLower)
            {
                case "math": 
                    Console.WriteLine("Math. Nerdy!");
                    break;
                case "science": 
                    Console.WriteLine("Science. Too hard!");
                    break;
                case "history": 
                    Console.WriteLine("History. Boring!");
                    break;
                case "literature": 
                    Console.WriteLine("Literature. blah blah blah!");
                    break;
                case "coding": 
                    Console.WriteLine("Coding. Now you're talking!");
                    break;
                case "recess": 
                case "lunch": 
                    Console.WriteLine($"{inLower}. always a favorite");
                    break;
                default:
                    Console.WriteLine($"{inLower}. I never studied that");
                    break;
            }
        }
    }
}
