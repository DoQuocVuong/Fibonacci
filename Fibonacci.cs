using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class Fibonacci
    {
        public static int fibonacci(int n) {
            if (n < 0) {
                return -1;
            } else if (n == 0 || n == 1) {
                return n;
            } else {
                return fibonacci(n - 1) + fibonacci(n - 2);
            }
        }
//        public static int tim(int n)
//        {
//             return tim(n-1)+ tim(n-2);
//        }
        public static void Main(string[] urg)
        {
            Console.WriteLine("Input number:");
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < x; i++) {
                           x += fibonacci(i);
                           Console.WriteLine(fibonacci(i) + " ");
            }
               
            Console.WriteLine("Tổng: " + x);
                   }
//            Console.WriteLine("Input number: ");
//            int x1 = 0;
//            int x2 = 1;
//            int x3 = 1;
//            int x = Convert.ToInt32(Console.ReadLine());
//            for (int i = 0; i < x; i++)
//            {
//                x1 = x2;
//                x2 = x3;
//                x3 = tim(i);
            }
            
        }
//    }
//}
