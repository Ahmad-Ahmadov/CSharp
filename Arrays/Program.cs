using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Array.ConvertAll(Console.ReadLine().Split(),int.Parse).Min());

            #region

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

            #endregion

            #region 6059

            //int sum = 0, n, t = int.Parse(Console.ReadLine());
            //for (int i = 0; i < t; i++)
            //{
            //    n = int.Parse(Console.ReadLine());
            //    sum = sum + n;
            //    Console.WriteLine(sum);
            //}

            //Console.ReadLine();

            #endregion

            #region 8255

            //var nums = Console.ReadLine().ToCharArray();
            //int[] digits = new int[nums.Length];
            //for (int i = 0; i < nums.Length; i++)
            //    digits[i] = Convert.ToInt32(nums[i].ToString());
            ////int n = int.Parse(Console.ReadLine());
            ////int sum = 0;
            //while (n != 0)
            //{
            //    sum = sum + n % 10;
            //    n /= 10;
            //}
            //Console.WriteLine(digits.Sum());

            //var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            //int n = nums[0], s = nums[1], m, sum = 0;
            //for (int i = (int)Math.Pow(10, n - 1); i < (int)Math.Pow(10, n); i++)
            //{
            //    m = i;
            //    while (m != 0)
            //    {
            //        sum = sum + m % 10;
            //        m /= 10;
            //    }
            //    if (sum == s)
            //        Console.WriteLine(i);
            //    sum = 0;
            //}

            //Console.ReadLine();

            #endregion

            #region 2862

            //int n = int.Parse(Console.ReadLine());
            ////int count = 0;
            //for (int i = 1; i <= n; i++)
            //    if (n % i == 0 & i % 2 != 0)
            //        Console.WriteLine(i);
            ////Console.WriteLine(count);

            #endregion

            #region 622

            //int n = int.Parse(Console.ReadLine());
            //int count = 0;
            ////while (n != 0)
            ////{
            ////    if (n % 2 == 1)
            ////        count++;
            ////    n /= 2;
            ////}
            //Console.WriteLine(count);

            #endregion

            #region 1609
            //string n = Console.ReadLine();
            //string a = Console.ReadLine();
            //int count = 0;

            //foreach (char i in n)
            //    if (a == i.ToString())
            //        count++;

            //Console.WriteLine(count);
            #endregion


            //int[] nums = {1, 2, 3, 40};
            //int[] nums2 = new int[150];
            //nums2[0] = 100;
            //nums2[1] = 150;
            //int[] nums3 = new int[4] {1, 2, 3, 4};
            int[] nums = { 12, 5, 6, 7, 82, 45, 5, 0, 1, 6 };
            int max = nums[0];
            int min = nums[0];
            foreach (var m in nums)
                if (m > max) max = m;


            //
            foreach (var m in nums)
                if (m < min) min = m;
            Console.WriteLine(max);
            Console.WriteLine(nums.Max());
            Console.WriteLine(nums.Min());
            Console.WriteLine(nums.Sum());
            Console.WriteLine(nums.Average());
            Console.WriteLine(nums.Length);
            Array.Sort(nums);
            Array.Reverse(nums);
            Console.WriteLine(nums[nums.Length-1]);
            Console.WriteLine(nums[0]);
            int[] nums1 = new int[nums.Length];
            Array.Copy(nums,nums1,nums.Length);
            Array.Clear(nums,2,3);
            Array.ForEach(nums,Console.WriteLine);
            int index = Array.IndexOf(nums, 5);
            int index1 = Array.LastIndexOf(nums, 5);//155656
            
        }
    }
}
