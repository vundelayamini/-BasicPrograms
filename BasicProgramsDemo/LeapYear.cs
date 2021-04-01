using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramsDemo
{
    class LeapYear
    {
        /// <summary>
        /// check leap year or not 
        /// </summary>
        public static void ReadLeapYer()
        {
            Console.WriteLine("Please Enter a Year");
            int LeapYear = Convert.ToInt32(Console.ReadLine());
            Leap(LeapYear);

        }    
          public static void Leap(int year)
          {

          
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                Console.WriteLine("Year is Leap Year");
            else
                Console.WriteLine("Year is not a Leap Year");


            Console.ReadKey();
          }
 
    }
}