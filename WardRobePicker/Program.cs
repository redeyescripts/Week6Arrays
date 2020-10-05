using System;
using System.Dynamic;

namespace WardRobePicker
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wardrobe = { "hat", "pants", "jacket", "shirt" };
            string[] colors = { "blue", "green", "yellow", "black" };

            string[] patterns = { "flowery", "striped", "polka dot", "circles", "checkered" };
            Console.WriteLine("Do you need help picking an outfit?");



            Random rnd = new Random();
            int randomIndex = rnd.Next(1, wardrobe.Length + 4);
            String userInput;
            userInput = Console.ReadLine();

            if (userInput == "no")
            {
                Console.WriteLine("LEAVE");
            }
            else
            {
                Console.WriteLine($"Today you wear" + $"{wardrobe[rnd.Next(0, wardrobe.Length)]}", $"{patterns[rnd.Next(0, patterns.Length)]}", $"{ colors[rnd.Next(0, colors.Length)]}");

            }

            if (userInput == "yes")
            {
                Console.WriteLine("Nice to hear");
            }
            else
            {
                Console.WriteLine($"Today you wear" + $"{wardrobe[rnd.Next(0, wardrobe.Length)]}", $"{patterns[rnd.Next(0, patterns.Length)]}", $"{ colors[rnd.Next(0, colors.Length)]}");

            }









        }
    }
}




