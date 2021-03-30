using System;

namespace BasicProgramsDemo
{
    class ReplaceString
    {
        public static void ReadInput()
        {
            
            string template = "Hello <<UserName>>, How are you?";
            Console.WriteLine("Please enter your name");
            string userInput = Console.ReadLine();
            ReplaceWord(template, userInput);
        }
      
        private static void ReplaceWord(string template, string userInput)
        {
            //using predefined string Replace() method to perform replace operation
            string result = template.Replace("<<UserName>>", userInput);
            // finally displaying updated template/statement
            Console.WriteLine("After done replace\t" + result);
        }
    }
}
