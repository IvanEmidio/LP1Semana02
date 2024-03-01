using System;

namespace SmoothOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Insere numero inteiro nao negativo: ");
            byte x = byte.Parse(Console.ReadLine());

            Console.WriteLine($"Decremento: {--x} ");
            Console.WriteLine($"Incremento: {++x}");


            /// Exercicio 4
            
            Console.WriteLine($"Divisao por 2: {x/2}");
            Console.WriteLine($"Shift Left por 3: {x<<3}");
            Console.WriteLine($"Xor com 5: {x^5}");

            if (x < 10)
            {
            Console.WriteLine("False");
            }
            else 
            {
            Console.Write("True");
            }


        }
    }
}
