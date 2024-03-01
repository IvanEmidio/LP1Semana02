using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Altura do cilindro: ");
            float a = float.Parse(Console.ReadLine());

            Console.Write("Raio do cilindro: ");
            float r = float.Parse(Console.ReadLine());

            ///Volume do Cilindro
            Console.WriteLine($"Volume do cilindro: {MathF.PI * MathF.Pow(r, 2) * a}");

            /// Superficie do Cilindro
            Console.WriteLine($"A supreficie do cilindro: {2 * MathF.PI * r * (r + a)}");
            
        }
    }
}
