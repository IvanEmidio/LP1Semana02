using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Todos os tipos
            
            sbyte sbt = sbyte.MaxValue;
            short sh = short.MaxValue;
            int inte = int.MaxValue;
            long lg = long.MaxValue;
            byte bt = byte.MaxValue;
            ushort ush = ushort.MaxValue;
            uint uinte = uint.MaxValue;
            ulong ulg = ulong.MaxValue;
            float fl = float.MaxValue;
            double db = double.MaxValue;
            decimal dec = decimal.MaxValue;

            Console.WriteLine("MaxValues: ");
            Console.WriteLine($"sbyte: {sbt} ");
            Console.WriteLine($"short : {sh} ");
            Console.WriteLine($"int: {inte}");
            Console.WriteLine($"long: {lg}");
            Console.WriteLine($"byte: {bt}");
            Console.WriteLine($"ushort: {ush}");
            Console.WriteLine($"uint: {uinte}");
            Console.WriteLine($"ulong: {ulg}");
            Console.WriteLine($"float: {fl}");
            Console.WriteLine($"double: {db}");
            Console.WriteLine($"decimal: {dec}");

            
        }
    }
}
