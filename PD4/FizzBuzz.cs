using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD4
{
    class FizzBuzz
    {
        public string GetOutput(int number)
        {
            if (number % 3 == 0)
            {
                if (number % 5 == 0)
                    return "FizzBuzz";
                else
                    return "Fizz";
            }
            else if (number % 5 == 0)
            {
                return "Buzz";
            }
            else
                return number.ToString();
        }
    }
}
