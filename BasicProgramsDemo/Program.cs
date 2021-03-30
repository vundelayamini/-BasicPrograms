using System;

namespace BasicProgramsDemo
{
    class Program
    {
        public  static void Main(string[] args)
        {
            ReplaceString.ReadInput();
            Console.Read();
            FlipCoin flip = new FlipCoin();
            flip.ReadInput();
            Console.Read();
        } 
    }
}
