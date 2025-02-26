using System;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            double pi = Math.PI;
            Console.WriteLine("Altura de um cilindro: ");
            string alt = Console.ReadLine();
            double a = double.Parse(alt);
            Console.WriteLine("Raio de um cilindro: ");
            string raio = Console.ReadLine();
            double b = double.Parse(raio);
            double volume = pi*(Math.Pow(b , 2)*(a));
            Console.WriteLine($"{volume:f3}");
            double area = 2*pi*b*(b+a);
            Console.WriteLine($"{area:f3}");
        }
    }
}
