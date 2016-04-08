using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_Assignment_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Restart:
            int sibling;
            try
            {
                Console.Write("Please enter the number of siblings: ");
                sibling = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("\n-------------------------------------------------------\n");

                Console.WriteLine("FORMAT: MM-DD-YYYY");

                DateTime[] dobArray = new DateTime[sibling];

                for (int i = 0; i < sibling; i++)
                {
                    Boolean isValid = false;

                    while (isValid != true)
                    {
                        Console.Write("Please enter the date of birth of sibling " + (i + 1) + ": ");
                        if (DateTime.TryParse(Console.ReadLine(), out dobArray[i]))
                        {
                            if (dobArray[i] < DateTime.Today)
                            {
                                isValid = true;
                            }
                            else
                            {
                                Console.WriteLine("Invalid date of birth");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid date format.");
                            isValid = false;
                        }
                    }
                }

                Console.WriteLine("\n-------------------------------------------------------\n");

                for (int j = 0; j < dobArray.Length; j++)
                {
                    TimeSpan age = DateTime.Today.Subtract(dobArray[j]);

                    int years = (int)(age.Days / 365.25);

                    int balance = (int)(age.Days - (years * 365.25));
                    int months = balance / 30;

                    balance = balance - (months * 30);
                    int days = balance;

                    Console.WriteLine("Age of sibling " + (j + 1) + " is: {0} years, {1} months, {2} days", years, months, days);
                }

                Console.WriteLine("\n-------------------------------------------------------\n");

                for (int k = 0; k < dobArray.Length; k++)
                {
                    if (k > 0)
                    {
                        TimeSpan age = dobArray[k].Subtract(dobArray[k - 1]);

                        int years = (int)(age.Days / 365.25);

                        int balance = (int)(age.Days - (years * 365.25));
                        int months = balance / 30;

                        balance = balance - (months * 30);
                        int days = balance;

                        Console.WriteLine("Difference between sibling {0} and {1} is {2} years {3} months and {4} days.", k, k + 1, Math.Abs(years), Math.Abs(months), Math.Abs(days));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input");
                goto Restart;
            }

            Console.ReadLine();
        }
    }
}
