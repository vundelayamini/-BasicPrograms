using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramsDemo
{
    class Gambler
    {
        public static void ReadStakeAmountAndGoal()
        {
            int wons = 0;
            int loose = 0;
            Console.WriteLine("Enter Stake amount");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Goal amount");
            int goal = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            for (int i = 1; i > 0; i++)
            {
                if (amount > 0)
                {
                    int randomValue = random.Next(0, 2);
                    //Console.WriteLine("Generated random value" + randomValue);
                    //won the game
                    if (randomValue == 1)
                    {
                        amount = amount + 1;
                        wons++;
                        if (amount == goal)
                        {
                            Console.WriteLine("Number of bets played in the game" + i);
                            Console.WriteLine("Number of wons" + wons);
                            Console.WriteLine("Number of loose" + loose);
                            break;

                        }

                    }
                    else
                    {
                        if(amount>0)
                        {
                            amount = amount - 1;
                            loose++;
                        }
                    }

                }
             
            }
            Console.WriteLine("final amount either it may reaches to goal or break the game");
        }

    }
}
