using System;
using System.Numerics;
using System.Text;

namespace DataTypes
{
    class Program
    {

        static void Main(string[] args)
        {
            /*
             * short ushort int uint long ulong BigInteger
             *
             * float double decimal 
             */
            //Console.WriteLine(short.MaxValue + 1);
            //Console.WriteLine(short.MinValue);
            //Console.WriteLine();
            //Console.WriteLine(ushort.MaxValue);
            //Console.Write(ushort.MinValue);
            //int a = 150;
            //int b;
            //b = 50;
            //double m = 5.6;
            //float n = 5.6F;
            //decimal k = 5.7m;
            //string txt = "20";
            //char c = 'a';
            //DateTime dt = DateTime.Now;
            //Console.WriteLine(dt.Day);
            //string text = Console.ReadLine();
            //int num = int.Parse(text);
            //int num2 = Convert.ToInt32(text);
            //double num3 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(num3.ToString().GetType());
            //Console.WriteLine(Math.Round(5.4));
            //Console.WriteLine(Math.Ceiling(5.4));
            //Console.WriteLine(Math.Floor(5.4));.
            //Console.WriteLine(56.0 / 5);
            //Console.WriteLine(Math.Max(21, 4));
            //Console.WriteLine(Math.Min(21, 4));
            //Console.WriteLine(Math.Abs(-5565));
            //Console.WriteLine(Math.Sqrt(64));
            //Console.WriteLine(Math.Pow(8, 2));
            //Console.WriteLine("Birinci reqem: " + 56 / 10 + '\n' + "Ikinci reqem: " + 56 % 10);
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine(num / 10 + " " + num % 10);
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Birinci rəqəm: " + 56 / 10 + '\n' + "Ikinci reqem: " + 56 % 10);
            long[] num = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long a = num[0], b = num[1];
            Console.WriteLine(a * a + b * b);
        }
    }
}
