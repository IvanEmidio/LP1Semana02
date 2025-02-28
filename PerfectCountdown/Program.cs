using System;

namespace PerfectCountdown
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string inicio, step;
            int resultado,ini,ste;
            
            do
            { 
            Console.Write("Start number: ");
            inicio = Console.ReadLine();
            ini = int.Parse(inicio);
            Console.Write("Step Number: ");
            step = Console.ReadLine();
            ste = int.Parse(step);

            resultado = ini/ste;

            if(ini <= 1 || ste < 1)
            { 
                Console.WriteLine("Out-of-range start or step. Try again.");
                ini = 1;
            }

            else if(ste >= ini)
            { 
                Console.WriteLine("Start must be higher than step. Try again.");
                ini = 1;
            }

            else if(ini % ste != 0)
            { 
                Console.WriteLine("Start not divisible by step. Try again.");
                ini = 1;
            }
            else
            {
                Console.WriteLine(resultado);
            }
            if(ini == 1)
            {
                continue;
            }


            }
            while(resultado != 0);
            
            

            

            


            

        }
    }
}
