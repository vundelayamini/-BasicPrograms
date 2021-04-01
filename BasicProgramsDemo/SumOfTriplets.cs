using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramsDemo
{
    class SumOfTriplets
    {
        /// <summary>
        /// this method impliented only for understanding the flow
        /// </summary>
        /// <param name="args"></param>
        public static void FindTriplets()
        {
            bool found = false;
            int[] array = { 12, 6, -6, -4, 5, 10 };

            for (int i = 0; i < array.Length; i++)
            {
                //i=0
                for (int j = i + 1; j < array.Length; j++)
                {
                    //j=1,j++
                    for (int k = j + 1; k < array.Length; k++)
                    {
                        //k=2,k=3,k=4,k=5,k=6
                        if (array[i] + array[j] + array[k] == 0)
                        {
                            found = true;
                            Console.WriteLine("[" + array[i] + "," + array[j] + "," + array[k] + "]");

                        }
                    }

                }

            }
            if (found == false)
                Console.WriteLine("Triplets not prsent in the given array");
        }
        public static void FindTripletWithHashSet()
        {
            bool found = false;
            int[] array = { 12, -6, 6, -4, 5, 10 };

            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < array.Length; i++)
            {
                //i=0
                for (int j = i + 1; j < array.Length; j++)
                {
                    //j=1
                    int thirdvalue = -(array[i] + array[j]);
                    if (set.Contains(thirdvalue))
                    {
                        Console.WriteLine("{" + array[i] + "," + array[j] + "," + thirdvalue + "}");
                        found = true;

                    }
                    else
                    {
                        set.Add(array[j]);
                    }

                }

            }
            if (found == false)
                Console.WriteLine("Triplets not present in the given array");
        }

    }
}

