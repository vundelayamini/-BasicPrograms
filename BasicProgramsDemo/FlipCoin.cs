using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramsDemo
{

    class FlipCoin
    {
       
        public void ReadInput()
        {
            Console.WriteLine("Please enter number of times to flip coin");
            string input = Console.ReadLine();
             int numbOfTimes = Convert.ToInt32(input);
            Flip(numbOfTimes);
        }

        private static void Flip(int numbOfTimes)
        {
           
            int tail = 0; int head = 0;
            Random random = new Random();
            for (int i = 1; i <= numbOfTimes; i++)
            {
               
                if (random.NextDouble() < 0.5)
                {
                   
                    tail++;
                }
                else
                   
                    head++;
            }
          
            double tailPercentage = (double)tail / numbOfTimes * 100;
            double headPercentage = (double)head / numbOfTimes * 100;
            Console.WriteLine("Tail count" + "=" + tail + "\tPercentage " + tailPercentage);
            Console.WriteLine("Head count" + "=" + head + "\tPercentage " + headPercentage);
        }
    }
}