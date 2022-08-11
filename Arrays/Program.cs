using System;
using System.Linq;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Array.ConvertAll(Console.ReadLine().Split(),int.Parse).Min());
            
            //8624
            // var object dynamic
            //object a = 1000; // boxing
            //int b = (int)a; // unboxing

            //var c = 52;
            //dynamic y = 150;
            //y = "Hello";
            //bool m = false;

            //a = "Hello";

            //a = true;
            //string num = Console.ReadLine();
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = i+1; j < 5; j++)
            //    {
            //        if (num[i] == num[j])
            //        {
            //            Console.WriteLine("YES");
            //            m = true;
            //            break;
            //        }
            //    }
            //    if(m==true) break;
            //}
            //if (m==false)
            //    Console.WriteLine("NO");

        }
    }
}
