using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMyPastTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many prime number do you want to generate: ");
            string numberText = Console.ReadLine();
            int number;
            while (!int.TryParse(numberText, out number) || number < 1)
            {
                Console.Write("Invalid format or incorrect number. Try again: ");
                numberText = Console.ReadLine();
            }

            var generator = new PrimeNumberGenerator();
            var table = new MultiplicationTable(generator.Generate().Take(Math.Min(10, number)).ToArray());
            var writer = new MultiplicationTableWriter();
            writer.Write(Console.Out, table);

            Console.Read();
        }
    }
}
