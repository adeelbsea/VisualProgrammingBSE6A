using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Birthday
{
    class DaysToBirthday
    {

        static void Main(string[] args)
        {
            DaysToBirthday obj = new DaysToBirthday();
            obj.getBirthday();
            Console.ReadLine();
        }

        private void getBirthday()
        {
            DateTime dob;
            Console.Write("Enter your birthday: ");
            DateTime.TryParse(Console.ReadLine(), out dob);
            calculateDays(dob);
        }

        private void calculateDays(DateTime dob)
        {
            TimeSpan age = DateTime.Today.Subtract(dob);
            int years = (int)(age.Days / 365.25);
            int balance = (int)(age.Days - (years * 365.25));
            int daysLeft = 365 - balance;
            Console.WriteLine("Days left to your birthday: " + daysLeft);
        }
    }
}
