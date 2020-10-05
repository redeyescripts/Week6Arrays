using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Dynamic;

namespace Week6Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] predictions = { " will win a new house", "lose your life", "lose your mind ", " win a brain ", "get a free bobo" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(1, predictions.Length + 5);
            //
            Console.WriteLine($"Today you will {predictions[randomIndex]}");


           


        }
    }
}
