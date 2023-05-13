using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Question_Set1
{
    public class Set_2
    {
        #region 1. Program to check if a Number is Positive, Negative or 0.
        public static string CheckNumber(int number)
        {
            return number > 0 ? "Given number is Positive" :
                number < 0 ? "Given number is negative" : "Given number is 0.";
        }
        #endregion

        #region 2. Check if two integers are equal or not
        public static string TwoInteger(int a, int b)
        {
            return a == b ? "Both a and b are same" : "Both a and b are not same";
        }
        #endregion
        
        #region 3. Check if two floating point numbers are equal or not

        public static string TwoFloat(double a, double b)
        {
            return a == b ? "Given floating numbers are equal" : "Given floating numbers are not equal";
        }

        #endregion
        
        #region 4. Program to Check if a Number is Odd or Even

        public static string OddEven(int Number)
        {
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
            return age > 18 ? "He/She is eligible for casting vote" : "He/She is not eligible for casting vote";
        }
        
        #endregion
        
        #region 7. Program to accept the height of a person in centimetre and categorize the person according to their height (tall, short or medium - assume threshold values)

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
        }

        #endregion

        #region 11. Given three numbers, find the two numbers that are closer to each other.

        public static string findCloser(double a, double b, double c)
        {
            double ab = Math.Abs(a - b);
            double bc = Math.Abs(b - c);
            double ac = Math.Abs(a - c);
            string result = string.Empty;
            if (ab < bc && ab < ac)
            {
                result = "A is closer to B";
            }
            else if(bc < ac)
            {
                result = "B is closer to C";
            }
            else
            {
                result = "A is closer to C";
            }

            return result;
        }

        #endregion

        #region 12. Given three numbers, find the two numbers that are farther from each other.

        public static string findFarther(double a, double b, double c)
        {
            double ab = Math.Abs(a - b);
            double bc = Math.Abs(b - c);
            double ac = Math.Abs(a - c);
            string result = String.Empty;
            if (ab > bc && ab > ac)
            {
                result = "A is farther value of B";
            }
            else if(bc >ac)
            {
                result = "B is farther value of C";
            }
            else
            {
                result = "A is farther value of C";
            }

            return result;
        }
        
        #endregion

        #region 13. Program to Sort three integers

        public static void Sorting(int a, int b, int c)
        {
            string Result = string.Empty;
            if (a > b)
            {
                Question_Set1.Program.Swap3(ref a, ref b);
            }

            if (a > c)
            {
                Question_Set1.Program.Swap3(ref a, ref c);
            }

            if (b > c)
            {
                Question_Set1.Program.Swap3(ref b, ref c);
            }

            Console.WriteLine(a+","+b+","+c);
            
            
            // int[] Arr = new int[n];
            // string Result = string.Empty;
            // for (int i = 1; i <= Arr.Length; i++)
            // {
            //     Console.WriteLine("Enter the number:{0}", i);
            //     double getValue = Convert.ToInt32(Console.ReadLine());
            //     if (Arr[i] < Arr[i+1])
            //     {
            //         Result = Question_Set1.Program.Swap3(Arr[i], Arr[i+1]);
            // //     }
            // }
        }
        

        #endregion

        #region 14. Program to check whether a triangle can be formed by the given value for the three angles.

        public static string TringleForm(double a, double b, double c)
        {
            string Result = String.Empty;
            if (((a + b) > c) && ((b + c) > a) && ((c + a) > b))
            {
                Result = "Given three angle values can be form triangle shape.";
            }
            else
            {
                Result = "Given three angle values can't be form triangle shape.";
            }

            return Result;
        }

        #endregion

        #region 15. Program to accept a coordinate point in an XY coordinate system and determne in which quandrant the coordinate point lies.

        public static string Quandrant(double a, double b)
        {
            string Result = string.Empty;
            if (a > 0 && b > 0)
            {
                Result = "1st Coordinate point in the quandrant";
            }
            else if (a < 0 && b > 0)
            {
                Result = "2nd Coordinate point in the quandrant";
            }
            else if (a < 0 && b < 0)
            {
                Result = "3rd Coordinate point in the quandrant";
            }
            else
            {
                Result = "4th Coordinate point in the quandrant";
            }

            return Result;
        }

        #endregion

        #region 16. Given a character, find it is a vowel or a consonant.

        public static string FindVowel(char value)
        {
            string Result = string.Empty;
            switch (value)
            {
                case 'a' : Result = value+" is a vowel";
                    break;
                case 'e': Result = value + " is a vowel";
                    break;
                case 'i': Result = value + " is a vowel";
                    break;
                case 'o' : Result = value + " is a vowel";
                    break;
                case 'u' : Result = value + " is a vowel";
                    break;
                default: Result = value + " is a consonant";
                    break;
            }
            // if (value == 'a' && value == 'A' && value == 'e' && value == 'E' && value == 'i' && value == 'I' &&
            //     value == 'o' && value == 'O' && value == 'u' && value == 'U')
            // {
            //     Result = "Given a character '"+value+"' is a vowel";
            // }
            // else
            // {
            //     Result = "Given a character '"+value+"' is a consonant";
            // }
            //
            return Result;
        }

        #endregion

        #region 17. Given the number of sides of a shape (3 sides up to 10 sides), return the name of that shape.

        public static string FindShape(int value)
        {
            int option = value;
            string result = string.Empty;
            switch (option)
            {
                case 3: result = "Trinangle";
                    break;
                case 4: result = "Quadrilateral";
                    break;
                case 5: result = "Pentagon";
                    break;
                case 6: result = "Hexagon";
                    break;
                case 7: result = "Heptagon";
                    break;
                case 8: result = "Octagon";
                    break;
                case 9: result = "Nonagon";
                    break;
                case 10: result = "Decagon";
                    break;
                default:
                    result = "Given sides are more than 10 or below 3";
                    break;
            }

            return result;
        }

        #endregion

        #region 18.Output number of days in a month given the month name.  Assume 28 days in February.

        public static string MonthToDays(string value)
        {
            string Result = string.Empty;
            value = value.ToLower();
            if (value == "february")
            {
                Result = value+" " + "month have a 28 days";
            }
            else if (value == "january" || value == "march" || value == "may" || value == "july" || value == "august" ||
                value == "october" && value == "december")
            {
                Result = value + " " + "month have a 31 days";
            }

            else if (value == "april" || value == "june" || value == "september" || value =="november")
            {
                Result = value + " " + "month have a 30 days";
            }
            else
            {
                Result = "Please enter a valid month";
            }

            return Result;
        }

        #endregion

        #region 19. Print the day of week (Monday or Tuesday,...)given the day of month (1 to 31). Assume the month starts on a Monday.

        public static string FindDay(int day)
        {
            string Result = string.Empty;
            int totalWeekdays = 7;
            while(day > 7)
            {
                day = day % 7;
                if (day == 0)
                {
                    day = 7;
                }
            }
            switch (day)
            {
                case 1 : Result = "Monday";
                    break;
                case 2: Result = "Tuesday";
                    break;
                case 3: Result = "Wednesday";
                    break;
                case 4: Result = "Thursday";
                    break;
                case 5: Result = "Friday";
                    break;
                case 6: Result = "Saturday";
                    break;
                case 7: Result = "Sunday";
                    break;
                default:
                    Result = "Invalid day";
                    break;
            }

            return Result;
        }

        #endregion

        #region 20. Read the lengths of sides of a triangle and name the triangle. (Equilateral, isosceles and scalene)

        public static string FindTraingleName(int a,  int b, int c)
        {
            string Result = String.Empty;
            if (a == b && a == c)
            {
                Result = "Equilateral Triangle";
            }
            else if (a == b || a == c || b == c)
            {
                Result = "isosceles Triangle";
            }
            else
            {
                Result = "Scalene Triangle";
            }

            return Result;
        }

        #endregion

        #region 21. Program to convert grade point to letter grade. (A=>90, B=>80, C=>60, D=>50, F<50)

        public static string Grade(double value)
        {
            string Grade = String.Empty;
            if (value >= 90)
            {
                Grade = "A Grade";
            }
            else if (value >= 80 && value < 90)
            {
                Grade = "B Grade";
            }
            else if (value < 80 && value >= 60)
            {
                Grade = "C Grade";
            }
            else if (value < 60 && value >= 50)
            {
                Grade = "D Grade";
            }
            else
            {
                Grade = "F Grade";
            }

            return Grade;

        }

        #endregion

        #region 22. What colour is that square, given the row as int (1-8) and column as char (a-h) in a chess board.
        // Given 5, 'a' the color is black, 3, 'd' the color is white.

        public static string FindColor(int value, char ch)
        {
            string color = string.Empty;
            if ((value % 2 != 0 && (ch == 'a' || ch == 'c' || ch == 'e' || ch == 'g')) || (value%2==0 && (ch == 'b' || ch == 'd' || ch == 'f' || ch=='h' )))
            {
                color = "Black";
            }
            else
            {
                color = "White";
            }

            return color;
        }
        

        #endregion

        #region 22. ii. Scissors, paper and rock

        public static void Game(int Player1, int Player2)
        {
            if (Player1 == 1)
            {
                if (Player2 == 1)
                {
                    Console.WriteLine("Both are same and match tied.");
                }
                else if(Player2==2)
                {
                    Console.WriteLine("Scissors cuts Papers");
                }
                else if (Player2 == 3)
                {
                    Console.WriteLine("Rock blunts Scissors");
                }
            }
            else if (Player1 == 2)
            {
                if (Player2 == 1)
                {
                    Console.WriteLine("Scissors cuts Papers");
                }
                else if(Player2==2)
                {
                    Console.WriteLine("Both are same and match tied.");
                }
                else if (Player2 == 3)
                {
                    Console.WriteLine("Paper wraps Rock");
                }
            }
            else if (Player1 == 3)
            {
                if (Player2 == 1)
                {
                    Console.WriteLine("Rock blunts Scissors");
                }
                else if(Player2==2)
                {
                    Console.WriteLine("Paper wraps Rock");
                }
                else if (Player2 == 3)
                {
                    Console.WriteLine("Both are same and match tied.");
                }
            }
        }

        #endregion

        #region 22. iii. Scissors, Paper and Rock Implemented

        public static int Game1(int Player1, int Player2, int getcount)
        {
            if (Player1 >= 1 && Player1 <= 3 || Player2 >= 1 && Player2 <= 3)
            {
                if (Player1 == 1 && Player2 == 1 || Player1 == 2 && Player2 == 2 || Player1 == 3 && Player2 == 3)
                {
                    Console.WriteLine("Both are same and match tied.");
                    return 3;
                }

                else if (Player1 == 1 && Player2 == 2 || Player1 == 2 && Player2 == 1)
                {
                    Console.WriteLine("Scissors cuts Papers.");
                    if (Player1 == 2 && Player2 == 1)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }

                else if (Player1 == 1 && Player2 == 3 || Player1 == 3 && Player2 == 1)
                {
                    Console.WriteLine("Rock blunts Scissors.");
                    if (Player1 == 1 && Player2 == 3)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
                else if (Player1 == 2 && Player2 == 3 || Player1 == 3 && Player2 == 2)
                {
                    Console.WriteLine("Paper wraps rcok.");
                    if (Player1 == 3 && Player2 == 2)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
            else
            {
                Console.WriteLine("Please enter valid option.");
            }

            return 3;

        }

        #endregion

        #region 23. Program to calculate roots of Quadratic Equation given a,b and c.

        public static void QuandraticEquation(double a, double b, double c)
        {
            double d,x1,x2 = 0;
            d = b * b - 4 * a * c;

            if (d == 0)
            {
                Console.WriteLine("Both roots are same");
                x1 = b / (2.0 * a);
                x2 = x1;
                Console.WriteLine("First Root = {0}",x1);
                Console.WriteLine("Second Root = {0}",x2);
            }
            else if (d > 0)
            {
                Console.WriteLine("Both roots are real and difference");

                x1 = (-b + Math.Sqrt(d) / (2.0 * a));
                x2 = (-b - Math.Sqrt(d) / (2.0 * a));
                
                Console.WriteLine("First Root = {0}",x1);
                Console.WriteLine("Second Root = {0}",x2);
            }
        }

        #endregion

        #region 24. Program to calculate profit and loss on a given transaction.

        public static void Transaction()
        {
            
        }

        #endregion

        #region 25. Menu-Driven Program to perform a simple calculation of addition, subtraction, multiplication, division and modulo division.

        public static void SimpleCalculator()
        {
            
            string input = string.Empty;
            do
            {
                Console.WriteLine("Enter the value of A:");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the value of B:");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the operator symbol");
                string operation = Console.ReadLine();
                switch (operation)
                {
                    case "+":
                        Console.WriteLine(Program.addition(a, b));
                        break;
                    case "-":
                        Console.WriteLine(Program.difference(a, b));
                        break;
                    case "*":
                        Console.WriteLine(Program.multiply(a, b));
                        break;
                    case "/":
                        Console.WriteLine(Program.division(a,b));
                        break;
                    // case "%":
                    //     return Program.modulus(a,b);
                    //     break;
                
                }

                Console.WriteLine("Type yes to continue...");
                input = Console.ReadLine();
            } while (input.ToLower() == "yes");
            
        }

        #endregion

        #region 26. Write a program for Rock, Paper and Scissors Game.  Just for a single round Computer vs. User and declare the winner with proper reason.

        public static void RoundGame()
        {
            int p1Count = 0;
            int p2Count = 0;
            int matchtied = 0;
            int round = 1;
            int getwoncount = 0;
            while(round<=5)
            {
                Random Rand = new Random();
                int randNumber = Rand.Next(1, 4);
                Console.WriteLine("Random generated number is: {0}",randNumber);
                Console.WriteLine("Please enter your choice number between 1 to 3: ");
                int userInput = Convert.ToInt32(Console.ReadLine());
                
                if(((Game1(randNumber, userInput, getwoncount)))==1)
                {
                    p1Count++;
                }
                else if(((Game1(randNumber, userInput, getwoncount)))==2)
                {
                    p2Count++;
                }
                else
                {
                    matchtied++;
                }
                
                round++;
            }

            if (p1Count == p2Count && matchtied>0)
            {
                Console.WriteLine("Match tied and count is: "+matchtied);
            }
            else if (p1Count > p2Count)
            {
                Console.WriteLine("Player 1 won the series and won count is: "+p1Count);
                Console.WriteLine("Player 2 won count is: {0}, Match tied count is: {1}",p2Count, matchtied);
            }
            else if (p1Count < p2Count)
            {
                Console.WriteLine("Player 2 won the series and won count is: {0}",p2Count);
                Console.WriteLine("Player 1 won count is: {0}, Match tied count is: {1}",p1Count, matchtied);
            }
            else
            {
                Console.WriteLine("Match tied and count is: "+matchtied);
            }
        }
        

        #endregion
    }
}