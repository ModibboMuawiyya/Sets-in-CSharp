using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Assignment
{
    class Number1
    { 
       

        public static void Main(string[] args)
        {
            int[] n = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] a = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] b = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };



            int[] num1 = { 1, 2, 4, 5 };
            int[] num2 = { 1,5,7,9,8 };

            convert(a, num1);
            convert(b, num2);


            Console.WriteLine("Elements in set A");
            print(a);
            Console.WriteLine();
            //
            Console.WriteLine("Element in B");
            print(b);
            Console.WriteLine();

            Console.WriteLine("AUB");
            Console.WriteLine();
            aUnionB(a, b);
            Console.WriteLine(1&1);
            Console.WriteLine();

            Console.WriteLine("AnB");
            Console.WriteLine();
            aIntersectb(a, b);
            Console.WriteLine();

            Console.WriteLine("A-B");
            Console.WriteLine();
            aDifferenceb(a, b);
            Console.WriteLine();

            Console.WriteLine("AEXorB");
            Console.WriteLine();
            aExorb(a, b);
            Console.WriteLine();



            Console.ReadLine();


        }

        private static void aExorb(int[] a, int[] b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == b[i])
                {
                    Console.Write("0");
                }
                else
                    Console.Write("1");
            }
        }

        private static void aDifferenceb(int[] a, int[] b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if ((a[i] == 1 && b[i] == 0))
                {
                    Console.Write("1" + " ");
                }
                else
                    Console.Write("0" + "");
            }
        }

        private static void aIntersectb(int[] a, int[] b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write((a[i] & b[i]) + " ");
            }
        }

        private static void aUnionB(int[] a, int[] b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write((a[i] | b[i])+ " ");
            }
        }

        private static void print(int[] k)
        {
            for (int i = 0; i < k.Length; i++)
            {
                Console.Write(k[i] + " ");
            }
        }

        private static void convert(int[] x, int[] y)
        {
            for (int i = 0; i < y.Length; i++)
            {
                x[y[i]] = 1;
            }
        }
    }
}
