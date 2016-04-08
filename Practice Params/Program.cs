using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Params
{
    class Program
    {
        public delegate int Del(params int[] arr);

        public static int average(params int[] arr)
        {
            int avg = 0;
            foreach (var item in arr)
            {
                avg = avg + item;
            }

            return avg = avg / arr.Length;
        }

        public static int sum(params int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }

            return sum;
        }

        public static int sumOfFunc(Del arr1, Del arr2)
        {
            return arr1(2,2) + arr2(2,2);
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(average(2,4));
            //Console.WriteLine(sum(1,2,3,4));

            Del delObj1 = new Del(average);
            Del delObj2 = new Del(sum);
            

            Console.WriteLine("Average: " + delObj1(1,3,4));
            Console.WriteLine("Sum: " + delObj2(1,3));
            Console.WriteLine("Functions sum: " + sumOfFunc(delObj1, delObj2));

            Console.WriteLine("String is: " + showString("BSE", 6, 'A'));

            Console.ReadLine();
        }


        public static string showString(params object[] arr)
        {
            string str = "";
            foreach (var item in arr)
            {
                str = str + item;
            }

            return str;
        }
    }
}
