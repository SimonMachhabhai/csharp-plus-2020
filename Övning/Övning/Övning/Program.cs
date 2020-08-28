using System;
using System.Diagnostics;
using System.Globalization;

namespace Övning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in värden: ");

            var input = Console.ReadLine();
            var inputArray = input.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            double[] numberArray = new double[inputArray.Length];


            for (int i = 0; i < inputArray.Length; i++)
            {
             

              


                

                

                //try
                //{
                //    numberArray[i] = Convert.ToDouble(inputArray[i]);


                    

                //}
                //catch (Exception)
                //{

                //    numberArray[i] = 0;

                //}

            }


        }

    }
}
