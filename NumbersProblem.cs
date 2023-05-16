using System;
using System.Globalization;
using System.Net.NetworkInformation;

namespace Question_Set2
{
    internal class NumbersProblem
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine("Enter the number: ");
            // int Number = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine(CheckNumber(Number));

            // Console.WriteLine("Enter the value of A:");
            // double a = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine("Enter the value of B:");
            // double b = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine(TwoInteger(a,b));
            // Console.WriteLine(TwoFloat(a,b));
            
            // Console.WriteLine(OddEven(Number));
            // Console.WriteLine(Leapyear(Number));
            // Console.WriteLine(voteEligible(Number));

            // Console.WriteLine("Enter the person height: ");
            // double height = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine(personHeight(height));

            // Console.WriteLine(LargeNumber(5363,16363,6362));
            // Console.WriteLine(smallestNumber(5363,16363,6362));
            //Console.WriteLine(LargestFour(53623,63362,636,1332));
            random(10);
        }

        #region 1. Program to check if a Number is Positive, Negative or 0.
        public static string CheckNumber(int number)
        {
            // string Result = string.Empty;
            // if (number > 0)
            // {
            //     Result = "Given number is Positive.";
            // }
            // else if(number<0)
            // {
            //     Result = "Given number is Negative.";
            // }
            // else
            // {
            //     Result = "Given number is 0";
            // }
            // return Result;
            return number > 0 ? "Given number is Positive" :
                number < 0 ? "Given number is negative" : "Given number is 0.";
        }
        #endregion

        #region 2. Check if two integers are equal or not
        public static string TwoInteger(int a, int b)
        {
            // string Result = string.Empty;
            // if (a == b)
            // {
            //     Result = "Both a and b are same.";
            // }
            // else
            // {
            //     Result = "Both a and b are not same.";
            // }
            // return Result;
            return a == b ? "Both a and b are same" : "Both a and b are not same";
        }
        #endregion

        #region 3. Check if two floating point numbers are equal or not

        public static string TwoFloat(double a, double b)
        {
            // string Result = string.Empty;
            // if (a == b)
            // {
            //     Result = "Given floating numbers are equal";
            // }
            // else
            // {
            //     Result = "Given floating numbers are not equal";
            // }
            //
            // return Result;
            return a == b ? "Given floating numbers are equal" : "Given floating numbers are not equal";
        }

        #endregion

        #region 4. Program to Check if a Number is Odd or Even

        public static string OddEven(int Number)
        {
            // string Result = string.Empty;
            // if (Number % 2 == 0)
            // {
            //     Result = "Given Number is Even.";
            // }
            // else
            // {
            //     Result = "Given number is Odd";
            // }
            //
            // return Result;
            return Number % 2 == 0 ? "Given Number is Even" : "Given Number is Odd";
        }

        #endregion

        #region 5. Program to Check Leap Year

        public static string Leapyear(int Year)
        {
            // string Result = string.Empty;
            // if (((Year % 4 == 0) && (Year % 100 == 0)) || (Year % 400 == 0))
            // {
            //     Result = "Given year is a leap year.";
            // }
            // else
            // {
            //     Result = "Given year is not a leap year.";
            // }
            //
            // return Result;
            return ((Year % 4 == 0) && (Year % 100 == 0) || (Year % 400 == 0))
                ? "Given year is a leap year"
                : "Given year is not a leap year";
        }
        
        #endregion

        #region 6. Read the age of a candidate and determine whether he/she is eligible for casting his/her own vote.

        public static string voteEligible(int age)
        {
            // string eligibleVote = string.Empty;
            // if (age > 18)
            // {
            //     eligibleVote = "He/she is eligible for casting vote";
            // }
            // else
            // {
            //     eligibleVote = "He/she is not eligible for casting vote";
            // }
            //
            // return eligibleVote;
            return age > 18 ? "He/She is eligible for casting vote" : "He/She is not eligible for casting vote";
        }
        
        #endregion

        #region 7. Program accept the height of a person in centimetre and categorize the person according to their height (tall, short or medium - assume threshold values)

        public static string personHeight(double height)
        {
            return (height <= 150) ? "Shortest person" : (height >= 151 && height <= 165) ? "Medium person" : "Tallest person";
        }
        
        #endregion

        #region 8. Program to Find the largest Among Three Numbers.

        public static double LargeNumber(double a, double b, double c)
        {
            double largest = double.MinValue;
            if (largest < a)
            {
                largest = a;
            }

            if (largest < b)
            {
                largest = b;
            }

            if (largest < c)
            {
                largest = c;
            }
            // return a > b && a > c ? "Given a number is bigger" :
            //     b > a && b > c ? "Given b number is bigger" : "Given c number is bigger";
            return largest;
        }
        
        #endregion
        
        #region 9. Program to Find the smallest Among Three Numbers.

        public static double smallestNumber(double a, double b, double c)
        {
            double smallest = double.MaxValue;
            if (smallest > a)
            {
                smallest = a;
            }

            if (smallest > b)
            {
                smallest = b;
            }

            if (smallest > c)
            {
                smallest = c;
            }
            // return a < b && a < c ? "Given a number is smaller" :
            //     b < a && b < c ? "Given b number is smaller" : "Given c number is smaller";
            return smallest;
        }
        
        #endregion

        #region 10. Find the largest among four numbers

        public static double LargestFour(double a, double b, double c, double d)
        {
            double largest = double.MinValue;
            if (largest < a)
            {
                largest = a;
            }

            if (largest < b)
            {
                largest = b;
            }

            if (largest < c)
            {
                largest = c;
            }

            if (largest < d)
            {
                largest = d;
            }
            return largest;
            // return a > b && a > c && a > d ? "Given a number is largest" :
            //     b > a && b > c && b > d ? "Given b number is largest" :
            //     c > a && c > b && c > d ? "Given c number is largest" : "Given d number is largest";
        }

        #endregion

        #region Random number generate

        private static void random(int n)
        {
            Random rand = new Random();
            Console.WriteLine(rand.Next());
            int i = 1;
            while (i <= n)
            {
                Console.WriteLine(rand.Next(1,100));
                i++;
            }
        }
        

        #endregion

        #region 13. Program to find the sort integers

        public static void sort()
        {
            for (int i = 0; i < 20; i++)
            {
                // Console.WriteLine(random());
            }
        }

        #endregion
    }
}