using System;
using System.Security.Cryptography;

namespace UserAgainstZombies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tell your items (5)");
            string[] bag = new string[5];
            //string[] bag = { "knife", "C4", "money", "keys","lighter" };
            int i = 0;
             while(i > bag.Length)
             {
                Console.WriteLine("Tell your items");
                bag[i] = Console.ReadLine();
                i++;
             }
            Random rnd = new Random();

            Console.WriteLine($"fight with zombies using "+ $"{bag[rnd.Next(0, bag.Length)]}");
        }
    }
}
