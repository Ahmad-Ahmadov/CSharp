using System;

namespace IfElseSwitchLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            //bool result = 5 > 6;
            //if (result)
            //{
            //    Console.WriteLine("Hello World");
            //}
            //if(n>0) Console.WriteLine("Sifirdan boyuk");
            //else if (n < 0) Console.WriteLine("Sifirdan kicik");
            //else Console.WriteLine("Sifir");
            //switch (n)
            //{
            //    case 1:
            //        Console.WriteLine("Hello 1");
            //        break;
            //    case 2:
            //        Console.WriteLine("Hello 2");
            //        break;
            //    default:
            //        Console.WriteLine(":(");
            //        break;
            //} 

            /*
             * for
             * while
             * do while
             * foreach
             * i++
             * ++i
             * i--
             * --i
             */
            //int m = 50;
            //int k = m--;
            //Console.WriteLine(k);
            //Console.WriteLine(m);
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 2; i < n; i++)
            //{
            //    if (n % i == 0)
            //    {
            //        Console.WriteLine("Sade deyil");
            //        return;
            //    }
            //}
            int count = 1;
            //while (n != 0)
            //{
            //    //count = count+(n%10);
            //    count = count + 10;
            //    n--;
            //}

            //do
            //{
            //    count += 5;
            //} while (n != 0);

            //int[] nums = { 1, 2, 3, 5, 6, 7, 8, 9, 10 };
            //string name = "Ahmad";

            //foreach (char m in name)
            //{
            //    Console.WriteLine(m);
            //}
            int[][] arrays = new int[3][];
            int[] a = {1, 2, 3, 4};
            int[] b = {5, 6, 12, 4};
            int[] c = {9, 7, 13, 8};
            arrays[0] = a;
            arrays[1] = b;
            arrays[2] = c;
            foreach (var m in arrays)
            {
                Console.WriteLine(m[0]);
            }
            Console.ReadLine();

        }
}
}
