using System;

namespace ValoresEspeciais
{
    public class Program
    {
        private static void Main(string[] args)
        {
            sbyte sb = sbyte.MaxValue;
            sbyte sb1 = sbyte.MinValue;
            double db = double.MaxValue;
            double db1 = double.MinValue;
            ulong ul = ulong.MaxValue;
            ulong ul1 = ulong.MinValue;
            int i = int.MaxValue;
            int i1 = int.MinValue;
            uint ui = uint.MaxValue;
            uint ui1 = uint.MinValue;
            byte b = byte.MaxValue;
            byte b1 = byte.MinValue;
            short s = short.MaxValue;
            short s1 = short.MinValue;
            long l = long.MaxValue;
            long l1 = long.MinValue;
            float f = float.MaxValue;
            float f1 = float.MinValue;

            float finf = float.PositiveInfinity;
            float finf1 = float.NegativeInfinity;
            double d = double.NaN;

            float f3, f4;

            f3 = f4 = 10000.0f;


            Console.WriteLine(sb);
            Console.WriteLine(sb1);
            Console.WriteLine(db);
            Console.WriteLine(db1);
            Console.WriteLine(ul);
            Console.WriteLine(ul1);
            Console.WriteLine(i);
            Console.WriteLine(i1);
            Console.WriteLine(ui);
            Console.WriteLine(ui1);
            Console.WriteLine(b);
            Console.WriteLine(b1);
            Console.WriteLine(s);
            Console.WriteLine(s1);
            Console.WriteLine(l);
            Console.WriteLine(l1);
            Console.WriteLine(f);
            Console.WriteLine(f1);

            Console.WriteLine(finf);
            Console.WriteLine(finf1);
            Console.WriteLine(d);

            Console.WriteLine(ui + 1);
            Console.WriteLine(2 * f);
            Console.WriteLine(f + 1);
            
            Console.WriteLine(f3 == f4 + 0.0001f);
            
        }
    }
}
