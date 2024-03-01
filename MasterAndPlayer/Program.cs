using System;

namespace MasterAndPlayer
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Number Master Insert Number: ");
            string x = Console.ReadLine();
            int n = int.Parse(x);
            

                if (n<0 || n>100)
                {
                    Console.WriteLine("Invalid Number!");
                }


                
                else 
                {

                for ( int i = 0; i < 100; i++ )
                {
                    Console.WriteLine(" ");
                }

                while(true)
                {

                    Console.Write("Player insert Number: ");
                    string y = Console.ReadLine();
                    int t = int.Parse(y);


                    if (t < 0 || t > 100)
                    {
                        Console.WriteLine("Invalid Number! Try again");
                        continue;
                    }

                    else if (t<n)
                    {
                        Console.WriteLine($"The correct number is Higher than {t}");   
                        continue;
                    }
                    else if(t>n)
                    {
                        Console.WriteLine($"The correct number is Lower than {t}");    
                        continue;
                    }
                    else if(t == n)
                    {
                        Console.WriteLine("Congratulations you guessed the number!");
                        break;
                    }


                }   
                

                }
                

            


        }
    }
}
