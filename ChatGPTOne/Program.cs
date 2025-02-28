using System;

namespace ChatGPTOne
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string s;
            do
            {
            Console.WriteLine("Make a Question.");
            s = Console.ReadLine();
            if (s == "What's your name?")
                Console.WriteLine("You can call me chat!");
            else if (s == "How old are you?")
                Console.WriteLine("I dont really have a age");
            else if (s == "Do you watch anime?")
                Console.WriteLine("I do watch anime sometimes");
            else if (s == "Do you eat?")
                Console.WriteLine("Depends on the food");  
            
            }
            while(s != "EXIT");
            


        }
    }
}
