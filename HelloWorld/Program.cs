
using System;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {

            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };

            foreach (var animal in animals)
            {
                if (animal.Length > 5)
                {
                    Console.WriteLine(animal);
                }

            }
            if (args.Length == 0)
            {
                Console.WriteLine("nothing here");
            }
            else
            {
                Console.WriteLine("Pick your poison:");
                for (var i = 0; i < args.Length; i++)
                {
                    Console.Write(args[i] + Environment.NewLine);
                }
                var userResponse = Console.ReadLine();
                switch (userResponse.ToLower())
                {
                    case "southern":
                        Console.WriteLine("Howdy Y'all!");
                        break;
                    case "meh":
                        Console.WriteLine("hey");
                        break;
                    case "texas":
                        Console.WriteLine("murrica! don't take mah guns!");
                        break;
                    default:
                        Console.WriteLine("Howdy, Y'all!");
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}