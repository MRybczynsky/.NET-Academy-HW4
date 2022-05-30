using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gra FizzBuzz");
            var FizzBuzz = new FizzBuzz();
            Console.WriteLine("Wprowadź liczbę:");
            while (true)
            {
                var number = getNum();
                Console.WriteLine(FizzBuzz.GetOutput(number));
                Console.WriteLine("Podaj następną liczbę lub zakończ (t)");
            }
            
        }

        private static int getNum()
        {
            var val = Console.ReadLine();
            if (val.ToUpper() == "T")
                Environment.Exit(0);
            while (true)
            {
                if (!int.TryParse(val, out int num))
                {
                    Console.WriteLine("Podałeś nieprawidlowe dane. Podaj inna liczbę");
                    continue;
                }
                return num;
            }
        }
    }
}
