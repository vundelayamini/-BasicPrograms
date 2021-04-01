using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramsDemo
{
    class PowerOfTwo
    {
        /// <summary>
        /// this is the power of two method
        /// </summary>
        public static void ReadPowerOfTwo()
        {

            Console.WriteLine("Please enter power of two");
            double PowerOfTwo = Convert.ToDouble(Console.ReadLine());
            Power(PowerOfTwo);


        }

        

        private static double Power(double Power)
        {
            int value = 2;
            for (Power = 1; Power <= 5; Power++)
            {
                Console.WriteLine("{0}^{1} = {2:N0}", value, Power, (long)Math.Pow(value, Power));

            
            }    return Power;
         }

    }
}

