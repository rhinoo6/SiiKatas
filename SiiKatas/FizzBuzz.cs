using System;

namespace SiiKatas
{
    public class FizzBuzz
    {
        public string DoFizzBuzz(int number)
        {
            // Implement your code here
            
                if (number % 3 ==0)
                {
                    return "Fizz";
                }
                else if (number % 5 == 0)
                {
                    return "Buzz";
                }
                else
                {
                return null;
                }
            throw new NotImplementedException();
        }
    }
}