using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Question_Set1
{
    internal class Set_5
    {
        //Note: Concentrate on Naming Conventions, Readability and Reusability of Functions. 
        //Try numbers from a different base for a real challenge. (Base 8 - Octal, Base 7, etc).

        #region 1. Program to count the number of digits in a given integer number
        public static int NoOfDigits(int value)
        {
            int DigitCount = 0;
            while(value>0)
            {
                value /= 10;
                DigitCount++;
            }
            return DigitCount;
        }

        #endregion

        #region 2. Check if the given number is of even length or odd length
        public static void CheckLengthIsOddOrEven(int value)
        {
            int DigitsCount = NoOfDigits(value);
            string Result = Set_2.OddEven(value);

            Console.WriteLine(Result);
        }
        #endregion

        #region 3. Find the sum of digits of a given integer
        public static int FindSumOfDigit(int value)
        {
            int SumOfDigit = 0;
            while(value>0)
            {
                int ModValue=value % 10;
                SumOfDigit += ModValue;
                value /= 10;
            }
            return SumOfDigit;
        }
        #endregion

        #region 4. i. Find the Sum of digits located in the odd/Even positions of a given number
        public static int FindSumOfOddPos(int value)
        {
            bool ToSkip = false;
            int Sum = 0;
            if(NoOfDigits(value) %2==0)
            {
                ToSkip = true;                
            }
            while (value > 0)
            {
                int Remainder = value % 10;
                if (!ToSkip)
                {
                    Sum += Remainder;
                }
                value /= 10;
                ToSkip = !ToSkip;
            }
            return Sum;
        }
        #endregion

        #region 4. ii. Find the Sum of digits located in the odd/Even positions of a given number
        public static int FindSumOfEvenPos(int value)
        {
            bool ToSkip = true;
            int Sum = 0;
            if(NoOfDigits(value)%2==0)
            {
                ToSkip = false;
            }
            while(value>0)
            {
                int Remainder = value%10;
                if(!ToSkip)
                {
                    Sum += Remainder;
                }
                value /= 10;
                ToSkip = !ToSkip;
            }
            return Sum;
        }
        #endregion

        #region 5. i. Count the number of Odd digits in an given integer.
        public static int CountOfOddDigit(int value)
        {
            int OddDigitCount = 0;
            while (value>0)
            {
                int Remainder = value % 10;                
                if(Remainder%2!=0)
                {
                    OddDigitCount++;
                }
                value /= 10;
            }
            return OddDigitCount;
        }
        #endregion

        #region 5. ii. Count the number of Even digits in an given integer.
        public static int CountOfEvenDigit(int value)
        {
            int EvenDigitCount = 0;
            while (value > 0)
            {
                int Remainder = value % 10;
                if (Remainder % 2 == 0)
                {
                    EvenDigitCount++;
                }
                value /= 10;
            }
            return EvenDigitCount;
        }
        #endregion

        #region 6. i. Find the sum of the odd digits of a given integer.
        public static int SumOfOddDigits(int value)
        {
            int SumOfOddDigits = 0;
            while(value>0)
            {
                int Remainder = value % 10;
                if (Remainder % 2 != 0)
                {
                    SumOfOddDigits += Remainder;
                }
                value /= 10;
            }
            return SumOfOddDigits;
        }
        #endregion

        #region 6. ii. Find the sum of the even digits of a given integer.
        public static int SumOfEvenDigits(int value)
        {
            int SumOfEvenDigits = 0;
            while(value>0)
            {
                int Remainder = value % 10;
                if(Remainder%2==0)
                {
                    SumOfEvenDigits+= Remainder;
                }
                value /= 10;
            }
            return SumOfEvenDigits;
        }
        #endregion

        #region 7. Get the Last digit of a given integer
        public static int GetLastDigit(int Input)
        {
            int LastDigit = 0;
            if (Input > 0)
            {
                LastDigit = Input % 10;
            }
            return LastDigit;
        }
        #endregion

        #region 8. Get the first digit of a given integer.
        public static int GetFirstDigit(int Input)
        {
            int FirstDigit = 0;
            while(Input>0)
            {
                FirstDigit = Input % 10;
                Input /= 10;
            }
            return FirstDigit;
        }
        #endregion

        #region 9. Given an integer, find the digit with maximum value. (I/P: 1890, O/P: 9)
        public static int FindMaxDigit(int Input)
        {
            int MaxDigit = 0;
            while(Input>0)
            {
                int CurrentDigit = 0;
                CurrentDigit = GetLastDigit(Input);
                Input /= 10;
                if(CurrentDigit>MaxDigit)
                {
                    MaxDigit = CurrentDigit;
                }
            }
            return MaxDigit;
        }
        #endregion

        #region 10. Given an integer find the location (1s, 10s, 100s, 1000s, etc.,) of the digit with maximum value. (I/P: 1890, O/P:10s)
        public static int FindLocationOfMaxDigit(int Input)
        {
            int Loc = 0;
            int MaxDigit = FindMaxDigit(Input);
            int CurrentLoc = 1;
            if(Input>0)
            {
                while (Input > 0)
                {
                    int CurrentDigit = 0;
                    CurrentDigit = GetLastDigit(Input);
                    
                    if (CurrentDigit == MaxDigit)
                    {
                        Loc = CurrentLoc;
                        break;
                    }
                    Input /= 10;
                    CurrentLoc *= 10;
                }
            }
            else
            {
                Loc = CurrentLoc;
            }
            return Loc;
        }

        #endregion

        #region 11. Given an integer find the digit with minimum value. (I/P: 1890, O/P: 0)
        public static int FindMinDigit(int Input)
        {
            int MinDigit = int.MaxValue;
            while (Input > 0)
            {
                int CurrentDigit = 0;
                CurrentDigit = GetLastDigit(Input);
                
                if (CurrentDigit <= MinDigit)
                {
                    MinDigit = CurrentDigit;                    
                }
                Input /= 10;
            }
            return MinDigit;
        }
        #endregion

        #region 12. Given an integer find the location (1s, 10s, 100s, 1000s, etc.,) of the digit with minimum value. (I/P: 1890, O/P: 1s)
        public static int FindLocationOfMinDigit(int Input)
        {
            int Loc = 0;
            int MinDigit = FindMinDigit(Input);
            
            if (Input > 0)
            {
                int Pow = 0;
                int CurrentLoc = 0;
                while (Input > 0)
                {
                    int CurrentDigit = 0;
                    CurrentDigit = GetLastDigit(Input);
                    CurrentLoc = (int)Math.Pow(10, Pow);
                    
                    if (CurrentDigit == MinDigit)
                    {
                        Loc = CurrentLoc;
                        break;
                    }
                    Input /= 10;
                    Pow++;
                }
            }
            else
            {
                return Loc;
            }
            return Loc;
        }
        #endregion

        #region 13. Reverse a given integer number N. (I/P: 1243, O/P: 3421).
        public static long Reverse(int Input)
        {
            int Reverse = 0;
            while(Input>0)
            {
                int CurrentDigit = Input % 10;
                Input /= 10;
                Reverse = Reverse * 10 + CurrentDigit;
            }
            return Reverse;
        }

        public static long ReverseUsingLong(long Input)
        {
            long Reverse = 0;
            while (Input > 0)
            {
                long CurrentDigit = Input % 10;
                Input /= 10;
                Reverse = Reverse * 10 + CurrentDigit;
            }
            return Reverse;
        }

        #endregion

        #region 14. Find the digital root of a given integer (Digital root means - Keep adding and folding till it becomes a single unit) (I/P: 8654, O/P: 5)
        public static int DigitalRoot(int Input)
        {
            int SumOfDigit = 0;
            while (Input > 0 || SumOfDigit > 9)
            {
                if (Input == 0)
                {
                    Input = SumOfDigit;
                    SumOfDigit = 0;
                }
                int CurrentDigit = Input % 10;
                SumOfDigit += CurrentDigit;
                Input /= 10;
            }
            return SumOfDigit;
        }
        #endregion

        #region 15. Check if all digits of a given integer N divides N(I/P: 486, O/P: False, I/P: 48, O/P: True)
        public static bool CheckIfAllDigitsDivideN(int value)
        {
            bool flag = false;
            int DigitLength = NoOfDigits(value);
            int DynamicValue = value;
            while(DynamicValue>0)
            {
                int CurrentDigit = GetLastDigit(DynamicValue);
                if(value%CurrentDigit==0)
                {
                    DigitLength--;
                }                
                DynamicValue /= 10;
            }

            return DigitLength > 0 ? flag : true;
        }
        #endregion

        #region 16. Program to count how many digits of a given integer N are divisible by another positive integer K(I/P: 486, K=2, O/P: 3; I/P=843, K=2, O/P: 2)
        public static int CountDigitsDivisibleByK(int value, int K)
        {
            int DynamicValue = value;
            int DivisibleCountByK = 0;
            while(DynamicValue>0)
            {
                int CurrentDigit = GetLastDigit(DynamicValue);
                if(CurrentDigit%K==0)
                {
                    DivisibleCountByK++;
                }
                DynamicValue /= 10;
            }
            return DivisibleCountByK;
        }
        #endregion

        #region 17. Check if a given two or three digit positive integer is a palindrome or not.
        public static bool CheckIfPalindrome(int value)
        {
            bool IsPalindrome = false;
            if(value == Reverse(value))
            {
                IsPalindrome = true;
            }
            return IsPalindrome;
        }
        #endregion

        #region 18. Check if the given positive long integer is palindrome or not.
        public static bool CheckPalindrome(long value)
        {
            bool IsPalindrome = false;
            if(value == ReverseUsingLong(value))
            {
                IsPalindrome |= true;
            }
            return IsPalindrome;
        }
        #endregion

        #region 19. Find the maximum number that can be formed using the digits of a given integer N. (I/P: 1890, O/P: 9810)
        public static int MaxDigitForm(int value)
        {
            int[] MyArray = value.ToString().Select(o=> Convert.ToInt32(o) - 48).ToArray();
            int Result = 0;
            Array.Sort(MyArray);
            for(int i=MyArray.Length-1;i>=0;i--)
            {
                Result = Result * 10 + MyArray[i];  
            }
            return Result;
        }
        #endregion

        #region 20. Find the minimum number that can be formed using the digits of a given integer N.
        public static int MinDigitForm(int value)
        {
            int[] MyArray = value.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();
            int Result = 0;
            Array.Sort(MyArray);
            for (int i = 0; i<MyArray.Length; i++)
            {
                Result = Result * 10 + MyArray[i];
            }
            return Result;
        }
        #endregion
    }
}