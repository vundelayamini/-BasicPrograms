using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramsDemo
{
    class Distance
    {
        /// <summary>
        /// Calculate distance using math 
        /// </summary>
        public static void ReadDistance()
        {
            int x, y;
            //declare variables
            Console.WriteLine("Enter X value:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y value :");
            y = Convert.ToInt32(Console.ReadLine());
            distance(x, y);
        }
        private static void distance(int x, int y)
        {
            double distance = Math.Sqrt(x * x + y * y);
            Console.WriteLine(distance);
        }
    }

}
