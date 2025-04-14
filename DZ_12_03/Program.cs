using DZ_12_03;

namespace DZ_12_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Простые числа до 60:");
            foreach (var i in PrimeNumbers.GetPrimes(60))
            {
                Console.Write(i + ", ");
            }

            Console.Write("\n");


            Console.WriteLine("Бесконечные простые числа:");
            foreach (var i in PrimeNumbers.GetAllPrimes())
            {
                Console.Write(i + ", ");
            }


            Console.Write("\n");


            Console.WriteLine(PrimeNumbers.IsPrime(6));


            Console.Write("\n");


            Console.WriteLine("Бесконечные простые числа без 10 первых простых чисел:");
            foreach (var i in PrimeNumbers.SkipPrimes(10))
            {
                Console.Write(i + ", ");
            }
        }
    }
}