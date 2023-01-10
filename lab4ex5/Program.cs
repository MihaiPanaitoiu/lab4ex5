using System;

namespace lab4ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Scrieti o functie recursiva care va calcula suma numerelor de la 1 pana la n,
             apelati-o si afisati-i rezultatul
             */
            Console.WriteLine("Introduceti n");

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(GetSumFromOneToN(n));
        }

        static int GetSumFromOneToN(int n)
        {
            int sum = 0;
            if (n > 0)
            {
                sum += n + GetSumFromOneToN(n - 1);
                return sum;
            }
            return sum;
        }
    }
}
