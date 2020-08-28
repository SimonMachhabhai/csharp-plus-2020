using System;

namespace Fredag._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange ett antal sifrror, seperat med kommatecken. ");
            var input = Console.ReadLine();
            var inputArray = input.Split(",", StringSplitOptions.RemoveEmptyEntries);

            foreach (var number in inputArray)
            {
                Console.WriteLine("Värdet är " + number);

            }

        }
    }
}
