using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Mate!");

            

            Console.WriteLine("Do you want to enter your name? (y/n)?");
            var key = Console.ReadKey();

            if (key.KeyChar == 'n')
                return;

            Console.WriteLine("Enter your name:");
            var name = Console.ReadLine();

            Console.WriteLine("Hello, " + name);
            Console.ReadKey();

            Console.WriteLine("Ange ålder");

            var input = Console.ReadLine();
            var integer = Convert.ToInt32(input);

            if (integer >= 18)
            {
                Console.WriteLine("Du är myndig");
            }
            else
            {
                Console.WriteLine("Näe");
            }

            Console.ReadKey();



        }
    }
}
