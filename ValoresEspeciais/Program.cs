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

            sbyte sbt1 = sbyte.MinValue;
            short sh1 = short.MinValue;
            int inte1 = int.MinValue;
            long lg1 = long.MinValue;
            byte bt1 = byte.MinValue;
            ushort ush1 = ushort.MinValue;
            uint uinte1 = uint.MinValue;
            ulong ulg1 = ulong.MinValue;
            float fl1 = float.MinValue;
            double db1 = double.MinValue;
            decimal dec1 = decimal.MinValue;

            Console.WriteLine("MinValues: ");
            Console.WriteLine($"sbyte: {sbt1} ");
            Console.WriteLine($"short : {sh1} ");
            Console.WriteLine($"int: {inte1}");
            Console.WriteLine($"long: {lg1}");
            Console.WriteLine($"byte: {bt1}");
            Console.WriteLine($"ushort: {ush1}");
            Console.WriteLine($"uint: {uinte1}");
            Console.WriteLine($"ulong: {ulg1}");
            Console.WriteLine($"float: {fl1}");
            Console.WriteLine($"double: {db1}");
            Console.WriteLine($"decimal: {dec1}");
            


        }
    }
}
