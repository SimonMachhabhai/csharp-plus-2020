using System;

namespace Fredag
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] interValues = new[] { 1, 2, 3 };
            var integerValuesName = nameof(interValues);

            for (var i = 0; i < interValues.Length; i++)
            {
                
                var value = interValues[i];

                Console.WriteLine($"Index {i} i arrayen {integerValuesName} har värdet: {value}");

            }

            var doWhileIndex = 0;

            do
            {
                var value = integerValuesName[doWhileIndex];

                Console.WriteLine($"Do while Index {doWhileIndex} i arrayen {integerValuesName} har värdet: ");

                doWhileIndex++;
            }



        }
    }
}
