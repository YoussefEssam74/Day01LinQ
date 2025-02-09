using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01LinQ
{
    internal static class IntExtention
    {
        // Extension Method 
        // Must be In Static and non Generic Class 
        public static int Reverse(this int /*IComparable*/ Number) //34an tshta8l m3 kolo 7t makan ini IComparable
        {
            int ReversedNumber = 0, Reminder;
            while (Number != 0)
            {
                Reminder = Number % 10;
                ReversedNumber  = ReversedNumber * 10 + Reminder;
                Number = Number / 10;
            }
            return ReversedNumber;
        }
    }
}

