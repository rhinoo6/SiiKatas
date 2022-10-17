using System;

namespace SiiKatas
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzz = new FizzBuzz();
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(fizzBuzz.DoFizzBuzz(i));
            }
        }
    }
}
