using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public  class PrimeFactorization
    {
        public void primeFactorization()
        {
            int i, j, num, isPrime;
            Console.Write("Input the number : ");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 2; i <= num; i++)
            {
                if (num % i == 0)
                {
                    isPrime = 1;
                    for (j = 2; j <= i / 2; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = 0;
                            break;
                        }
                    }
                    if (isPrime == 1)
                    {
                        Console.WriteLine(i);
                    }
                }

            }
        }
    }
}
