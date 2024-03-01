using System;

namespace ChatGPTOne
{
    class Program
    {
        static void Main(string[] args)
        {
             do
            {
                Console.Write("What's in your mind? ");
                chat = Console.ReadLine();
                
                if (chat == "Are you an AI?")
                {
                    res = "They say i am";
                }
                else if (chat == "What are you doing?")
                {
                    res = "Right now?....answering you....";
                }
                else if (chat == "How old are you?")
                {
                    res = "i prefer not to answer that";
                }
                else if (chat == "can you tell how many fingers i have up right now?")
                {
                    res = "no.";
                }
                else if (chat == "EXIT")
                {
                    break;
                }
                else
                {
                    res = "Sorry i couldn't understand...";
                }
            
                Console.WriteLine(res);

            }   while (true);
        }
    }
}
