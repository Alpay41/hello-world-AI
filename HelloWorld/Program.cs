
using System;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Howdy Y'all!!"); // greeting lines
            Console.WriteLine("what should I call you?");

            var name = Console.ReadLine(); // read user input

            Console.WriteLine($"hey {name}"); // string interpolation
            Console.WriteLine("what's your fav color?");

            var favoriteColor = Console.ReadLine(); // read user input


            var animals = new String[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };

            foreach (var animal in animals) // print animals with more than 5 chars
            {
                {
                    if (animal.Length > 5)
                    {
                        Console.WriteLine(animal);
                    }
                }
            }

            Random rand = new Random(); // new random string
            int index = rand.Next(animals.Length); // random selection of animals that fulfill earlier conditional
            Console.WriteLine($"how's about a {favoriteColor} {animals[index]}?"); // prints user input + random animal

            Console.WriteLine("Pick your poison:"); // new section of command line
            for (var i = 0; i < args.Length; i++)
            {
                Console.Write(args[i] + Environment.NewLine);
            }
            var userResponse = Console.ReadLine();
            switch (userResponse.ToLower()) // switch case for greetings, will convert chars in user input to lower case
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
    }
}