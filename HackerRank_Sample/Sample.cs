using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Sample
{
    public static class Sample
    {
        public static void fizzBuzz(int n)
        {
            for (var cntr = 1; cntr <= n; cntr++)
            {
                if (cntr % 3 == 0)
                {
                    if (cntr % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else
                    {
                        Console.WriteLine("Fizz");
                    }
                }
                else if (cntr % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(cntr);
                }
            }
        }

    }
}
