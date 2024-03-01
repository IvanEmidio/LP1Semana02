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



        }
    }
}
