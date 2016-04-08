using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice26mar
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 3, 2, 9, 6, 10 };
            
            //secondHighest(arr);
            //sumPair(arr);
            removeDuplicate(arr);
            //isSquare();
            //isNumPalindrome();

            Console.ReadLine();
        }



        //--------How do you find second highest number in an integer array?

        //public static void secondHighest(int[] arr)
        //{
        //    int secondLargest = arr.OrderBy(value => value).Reverse().ElementAt(1);
        //    Console.WriteLine("Second largest number is: " + secondLargest);
        //}




        //---------How to find all pairs in array of integers whose sum is equal to given number?

        //public static void sumPair(int[] arr)
        //{
        //    Console.Write("Enter any number: ");
        //    int num = Convert.ToInt16(Console.ReadLine());

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        for (int j = i + 1; j < arr.Length; j++)
        //        {
        //            if (arr[i] + arr[j] == num)
        //            {
        //                Console.WriteLine("Pair: " + arr[i] + " and " + arr[j]);
        //            }
        //        }
        //    }
        //}



        //---------How to remove duplicate elements from array in Java?  

        public static void removeDuplicate(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        //arr = arr.Where(value => value != arr[j]).ToArray();

                        Console.WriteLine("Duplicate removed: " + arr[j]);
                        arr = arr.Where((source, index) => index != j).ToArray();

                        Console.Write("New array: ");
                        foreach (var item in arr)
                        {
                            Console.Write(item + ", ");
                        }

                    }
                }
            }
        }



        //---------Write code to check whether a no is power of two or not?

        //public static void isSquare()
        //{
        //    Console.Write("Enter number: ");
        //    int num = Convert.ToInt16(Console.ReadLine());
        //    int square = 1;

        //    while(num >= square)
        //    {
        //        if (num == square)
        //        {
        //            Console.WriteLine(num + " is power of two.");
        //            break;
        //        }
        //        square = square * 2;
        //    }
        //}



        //public static void isNumPalindrome()
        //{
        //    Console.Write("Enter number: ");
        //    int originalNum = Convert.ToInt16(Console.ReadLine());
       
        //    int num = originalNum;
        //    int reverse = 0;
        //    while (num != 0)
        //    {
        //        reverse = reverse * 10 + num % 10;
        //        num = num / 10;
        //    }

        //    if(reverse == originalNum)
        //    {
        //        Console.WriteLine(reverse + " is a palindrome");
        //    }
        //    else
        //    {
        //        Console.WriteLine(reverse + " is not a palindrome");
        //    }
        //}


    }
}
