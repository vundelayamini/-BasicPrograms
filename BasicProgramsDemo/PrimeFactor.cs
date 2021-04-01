using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramsDemo
{
    class PrimeFactor
    {
       public static void ReadPrimeFactor()
        {
            Console.WriteLine("Please enter your number");
            int num;
           num = Convert.ToInt32(Console.ReadLine());
           Prime(num);


        }
        public static void Prime(int n)
        {

            // Print the number of 2s that divide n 
            while (n % 2 == 0)
            {
                Console.Write(2 + " ");
                n /= 2;
            }

            // n must be odd at this point. So we can 
            // skip one element (Note i = i +2) 
            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                // While i divides n, print i and divide n 
                while (n % i == 0)
                {
                    Console.Write(i + " ");

                    n /= i;
                }
            }

            // This condition is to handle the case whien 
            // n is a prime number greater than 2 
            if (n > 2)
                Console.Write(n);
        }

    }
}

