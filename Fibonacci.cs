using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class Fibonacci
    {
//        public static int fibonacci(int n) {
//            if (n < 0) {
//                return -1;
//            } else if (n == 0 || n == 1) {
//                return n;
//            } else {
//                return fibonacci(n - 1) + fibonacci(n - 2);
//            }
//        }
        public static int tim(int n)
        {
            int a1 = 1;
            int a2 = 2;
            if (n == 1 || n == 2)
            {
                return 1;
            }

            int i = 3;
            int a;
            while (i <= n)
            {
                a = a1 + a2;
                a1 = a2;
                a2 = a;
                i++;
                
            }

            return a1 + a2;
        }

        public static void Main(string[] urg)
        {
//            Console.WriteLine("Input number:");
//            int x = Convert.ToInt32(Console.ReadLine());
//            for (int i = 0; i < x; i++) {
//                           x += fibonacci(i);
//                           Console.WriteLine(fibonacci(i) + " ");
//            }
//               
//            Console.WriteLine("Tổng: " + x);
//                   }
            Console.WriteLine("Input number: ");
            int x1 = 0;
            int x2 = 1;
            int x3 = 1;
            int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Số cần tìm là:"+ tim(n));
        }
    }
}
