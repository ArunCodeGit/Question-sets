using System;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace Question_Set1
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            #region Set 1
            // Console.Write("Enter the value of number A: ");
            // double a = Convert.ToDouble(Console.ReadLine());
            // Console.Write("Enter the value of number B: ");
            // double b = Convert.ToDouble(Console.ReadLine());
            // Console.Write("Enter the value of number C: ");
            // double c = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine("Addition result: "+addition(a,b));
            // Console.WriteLine("Difference result:"+difference(a,b));
            // Console.WriteLine("Multiplication result: "+multiply(a,b));
            //Console.WriteLine("a power of b: "+power(a,b));
            //Console.WriteLine("Rectangle result is: "+ rectangle(20,10, 5));
            //Console.WriteLine("Perimeter value is: "+perimeter(4.5));
            //Console.WriteLine("Result is: "+division(20, 3));
            // Console.WriteLine("Square value is: "+ Square(25));
            // Console.WriteLine("Square root of given number: "+ SqureRoot(625));
            //Console.WriteLine("Result for Area of a Triangle: "+ AreaTriangle(1000, 55));
            //AreaTriangle();
            // Console.WriteLine(KMtoMiles(1353)+" miles");
            // Console.WriteLine(MilestoKM(6323)+" kilometers.");
            // Console.WriteLine(CelsiustoFahrenheit(34)+" fahrenheit");
            // Console.WriteLine(FahrenheittoCelsius(93.2)+" celsius");
            //Swap1(1534,36313);
            //Swap2(23563,636371);
            // Swap3(153, 61);
            //random(1,3);
            //Console.WriteLine(area(208.75,208.71));
            //Console.WriteLine(SumNatural(100));
            //Console.WriteLine(avg(a,b,c));
            // Console.WriteLine(tips(1000,3.25));

            // Console.WriteLine("Enter the amount : ");
            // double Amount = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine("Enter the tax percentange");
            // double tax = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine(netTotal(Amount, tax));
            //
            // Console.WriteLine("Enter the Dearness Allowance: ");
            // double DA = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine("Enter the Travelling Allowance: ");
            // double TA = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine("Enter the provident fund: ");
            // double PF = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine("Gross Pay = "+GrossPay(Amount,DA,TA, PF));

            // Console.WriteLine("Enter the princial amount: ");
            // double PA = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine("Enter rate of interest: ");
            // double r = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine("Enter the value of n: ");
            // double n = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine(simpleInterest(PA,r, n));

            //Console.WriteLine(compoundInterest(15000, 12, 6, 2));

            //Console.WriteLine(personHeight(174));
            //Console.WriteLine(BMI(180, 65));

            // Console.WriteLine("Enter the roll number: ");
            // int RollNo = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Enter the Student Name: ");
            // string StudName = Console.ReadLine();
            // Console.WriteLine("Enter three subjects marks: ");
            // int mark1 = Convert.ToInt32(Console.ReadLine());
            // int mark2 = Convert.ToInt32(Console.ReadLine());
            // int mark3 = Convert.ToInt32(Console.ReadLine());
            // display(RollNo, StudName, mark1, mark2, mark3);
            

            #endregion
            
            #region Set 2
            // Console.WriteLine(Set_2.CheckNumber(152));
            // Console.WriteLine(Set_2.TwoInteger(3632,163331));
            // Console.WriteLine(Set_2.TwoFloat(63.62,636.263));
            // Console.WriteLine(Set_2.OddEven(33));
            // Console.WriteLine(Set_2.Leapyear(2000));
            // Console.WriteLine(Set_2.voteEligible(32));
            // Console.WriteLine(Set_2.personHeight(164.6));
            // Console.WriteLine(Set_2.LargeNumber(264.4,74.63,24.372));
            // Console.WriteLine(Set_2.smallestNumber(3612.631,36312.673,63136.62));
            // Console.WriteLine(Set_2.LargestFour(363,163,631,363));
            // Console.WriteLine(Set_2.findCloser(99,100,101));
            // Console.WriteLine(Set_2.findFarther(100,150,200));
            //Set_2.Sorting(953, 631, 753);
            //Console.WriteLine(Set_2.TringleForm(10,16,25));
            //Console.WriteLine(Set_2.FindVowel('O'));
            //Console.WriteLine(Set_2.Quandrant(-52,-63));
            //Console.WriteLine(Set_2.FindShape(10));
            //Console.WriteLine(Set_2.MonthToDays("november"));
            //Console.WriteLine(Set_2.FindDay(26));
            //Console.WriteLine(Set_2.FindTraingleName(50,50,50));
            //Console.WriteLine(Set_2.Grade(75.05));
            //Console.WriteLine(Set_2.FindColor(5,'d'));
            //Set_2.Game1(3,3);
            //Set_2.QuandraticEquation(1, 5, 2);
            //Set_2.SimpleCalculator();
            //Set_2.RoundGame();
            

            #endregion

            #region Set 3

            //set_3.PrintNumber(1000);
            //set_3.PrintNumber1(101,250);
            //set_3.PrintEventNumbers(100);
            //set_3.PrintOddNumbers(100);
            //set_3.MNEvenNumber(1000, 1200);
            //set_3.Sample();
            //set_3.DivN();
            //set_3.TableForm(20, 10);
            //set_3.Tables();
            //Console.WriteLine(set_3.sumNumbers(20));
            //Console.WriteLine(set_3.sumEvenNumbers(10));
            //Console.WriteLine(set_3.sumOddNumbers(10));
            //set_3.SumOfMultiple();
            //set_3.FizzBuzz();
            //set_3.FindFactorial();
            //set_3.PromptUser();
            //set_3.PromptScore();
            //set_3.MenuDrivenCalculator();
            //set_3.MagicNumbers(1,30);
            set_3.RPS();
            #endregion

            #region Set 4

            //set_4.FindFactorial();
            //set_4.IsPrime(21);
            //set_4.PrintAllPrime();
            //set_4.FirstNPrime();
            //set_4.PrimelessthanN();
            //set_4.SumOfFirstNPrime();
            //set_4.SumOfAllPrimeNumbers();
            //set_4.PrimeMN();
            //set_4.PrimeFactor();
            // Console.Write("Enter the value of M: ");
            // int M = Convert.ToInt32(Console.ReadLine());
            // Console.Write("Enter the value of N: ");
            // int N = Convert.ToInt32(Console.ReadLine());
            // Console.Write("Enter the value of Kth prime number: ");
            // int K = Convert.ToInt32(Console.ReadLine());
            //set_4.FindPrimeMN(M,N);
            // set_4.PrintPrimeMN(M,N);
            // set_4.FindPrimeMN1(M,N);
            // set_4.nextprimeInt(N);
            // set_4.PreviousPrimeInt(N);
            // set_4.nearestPrime(N);
            //set_4.KthPrimeNumber(N, K);
            //set_4.FindExistsPrime(M,N);
            //set_4.DistinctPrimeFactor(M,N);
            //set_4.ProductofPrime(N);
            //set_4.DistinctUnique(N);
            // set_4.LargestPrime(M,N);
            // set_4.SmallestPrime(M, N);

            #endregion

        }
        #region 1) i. Given two integers, write a program to display the sum, differenc, and their product
        public static double addition(double a, double b)
        {
            return a + b;
        }
        #endregion
        
        #region  1) ii. Difference

        public static double difference(double a, double b)
        {
            return a - b;
        }
        #endregion
        
        #region 1) iii. Multiplication
        public static double multiply(double a, double b)
        {
            return a * b;
        }
        #endregion

        #region Modulus

        public static double modulus(ref int a, ref int b)
        {
            return  a % b;
        }

        #endregion

        #region Division

        public static double division(double a, double b)
        {
            return a / b;
        }

        #endregion

        #region 2) Write a program to find the value of a raised to the power of b, where a & b are positive integers. Use Math.Pow()
        public static double power(double a, double b)
        {
            //return Math.Pow(a, b);
            double temp = 1;
            while (b != 0)
            {
                temp = temp * a;
                b--;
            }
            return temp;
        }
        #endregion

        #region 3) Write a program to find the volume of a rectangular water tank. Hint(length * Width * Height)
        public static double rectangle(double length, double width, double height)
        {
            return (length * width * height);
        }
        #endregion

        #region  4) Fidn the perimeter of a circle given the radius. Hint (2 * PI* r) Use Math.PI.
        public static double perimeter(double radius)
        {
            return (2 * Math.PI * radius);
        }
        #endregion

        #region 5) Given a numerator and denominator, find the quotient and remainder.
        public static string divisionwithRemainder(int numerator, int denominator)
        {
            string Result = string.Empty;
            if (denominator > 0)
            {
                int quotient = numerator / denominator;
                int remainder = numerator % denominator;
                Result = "Quotient: " + quotient;
                Result += " "+"Remainder: " + remainder;
            }
            else
            {
                Result = "Given denominator value is less than 1";
            }
            return Result;
        }
        #endregion

        #region 6) Program to find the Square of a given number (hint: a* a or Math.Pow(a,2))
        public static double Square(double number)
        {
            //return (number * number);
            return Math.Pow(number, 2);
        }
        #endregion

        #region 7) Program to find the square root of a given number. Hint: Use Math.Sqrt() function.
        public static double SqureRoot(double number)
        {
            return Math.Sqrt(number);
        }
        #endregion

        #region 8) Program to Calculate the Area of a Triangle. Hint: (1/2 * (b*h))
        public static void AreaTriangle()
        {
            int breadth = 100;
            int height = 55;
            Console.WriteLine(1/2*(breadth* height));
            //return ((1 / 2) * (breadth * height));
        }
        #endregion
        
        #region 9) i. Program to Convert Kilometers to Miles.  Hint: (1 mile = 1.60934km or 1 km = 0.621371 mile)
        public static double KMtoMiles(double km)
        {
            return km * 0.621371;
        }
        #endregion

        #region 9) ii. Miles to Kilometers

        public static double MilestoKM(double miles)
        {
            return miles * 1.60934;
        }
        #endregion

        #region 10) i. Program to Convert Celsius to Fahrenheit. Hint: F=(C*9/5)+32
        public static double CelsiustoFahrenheit(double celsius)
        {
            return ((celsius * 9 / 5) + 32);
        }
        #endregion

        #region 10) ii. Program to convert Fahrenheight to Celsius. Hint C= (F*5/9)+32)
        public static double FahrenheittoCelsius(double fahrenheit)
        {
            return ((fahrenheit * 5/9) + 32);
        }
        #endregion

        #region 11. Program to Swap Two variables
        public static void Swap1(int a, int b)
        {
            Console.WriteLine("Before Swap a = {0}, b = {1}", a,b);
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After Swap a = {0}, b = {1}", a,b);
        }
        #endregion

        #region 12. Program to Swap Two variables
        public static void Swap2(int a, int b)
        {
            Console.WriteLine("Before swap a = {0}, b = {1}", a,b);
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("After Swap a = {0}, b = {1}", a,b);
        }
        #endregion

        #region 13. Program to Swap Two variables without causing overflow
        public static void Swap3(ref int a, ref int b)
        {
            a = a ^ b;
            b = a ^ b;
            a = b ^ a;
            Console.WriteLine(a+","+b);
          //  return a + ", " + b;
            // Console.WriteLine(a+", "+b);
        }
        #endregion

        #region 14. Program to Generate a Random number between 1 and 100. Hint: Use Next() method from Random Class
        public static void random(int init, int end)
        {
            Random rand = new Random();
            Console.WriteLine(rand.Next());
            string Result = string.Empty;
            for (int i = init; i <= end; i++)
            {
                Console.Write(rand.Next(1,100)+" ");
                //Result = rand.Next(init, end);
            }

            //return Result;
        }
        #endregion

        #region 15. Find the area of a field in acres, whose length and width are given in feet.  Hint: (1 acre = 43,560 sq ft)
        public static double area(double length, double width)
        {
            double feet = length * width;
            double acre = feet / 43560;
            return acre;
        }
        #endregion

        #region 16. Program to Find the Sum of Natural Numbers up to
        public static double SumNatural(double number)
        {
            return (number* (number + 1) / 2);
        }
        #endregion

        #region Total calculation

        private static double Total(double a, double b, double c)
        {
            return a + b + c;
        }

        #endregion

        #region 17. Get three numbers as input from the user and find their average
        private static double avg(double a, double b, double c)
        {
            return Total(a,b,c) / 3;
        }
        #endregion

        #region 18. Write a program to calculate the tip to be provided to the waiter, at 5% of bill amount.
        public static double tips(double amt, double tips)
        {
            tips = +amt + GetPercentange(tips, amt);
            return amt + tips;
        }
        #endregion

        #region 19. Given the total amount paid and the tax percentage, calculate the net amount of the product backwards.
        public static double netTotal(double amt, double tax)
        {
            double taxAmt = GetPercentange(tax, amt);
            return amt += taxAmt;
        }
        #endregion

        #region 20) Given the basic pay, DA%, and TA%, PF @ 8%deduction, calculate the gross pay. Hint: (Basic Pay + DA + TA -PF)

        public static double GrossPay(double basicPay, double da, double ta, double pf)
        {
            basicPay += (GetPercentange(da,basicPay)) + GetPercentange(ta,basicPay) - GetPercentange(pf,basicPay);
            return basicPay;
        }

        public static double GetPercentange(double percent, double value)
        {
            percent /= 100;
            percent = value * percent;
            return percent;
        }
        #endregion

        #region 21) Write a program to calculate simple interest. Hint: (P*n*r/100)

        public static double simpleInterest(double principalamt, double rateOfInterest, double n)
        {
            return ((principalamt * n * rateOfInterest) / 100);
        }

        #endregion

        #region 22) Write a program to compute compound interest.  Hint: (P*((1+r/n)^(nt))), where P is the initial principal balance,  r is the number of time periods.  ^ refers to power.

        public static int compoundInterest(int P, int r, int n, int t)
        {
            int nt = (n * t);
            int rn = (1 + r / n);
            return (P * (rn ^ nt));
        }

        #endregion

        #region 23) Given the height of a person in cm print the height in feet & inches. (1 inch = 2.54cm)

        public static double personHeight(double cm)
        {
            return (cm / 2.54);
        }

        #endregion

        #region 24) Program to find BMI given height in meters and weight in kilograms.  Hint: Weight/Height*Height

        public static double BMI(double weight, double height)
        {
            return ((weight / height) * height);
        }

        #endregion

        #region 25) Program to read roll no, name and marks of three subjects and calculate the total and average.
        public static void display(int rollno, string name, double m1, double m2, double m3)
        {
            Console.WriteLine("Roll Number: "+rollno);
            Console.WriteLine("Student Name: "+name);
            Console.WriteLine("Mark 1"+ m1);
            Console.WriteLine("Mark 2:" +m2);
            Console.WriteLine("Mark 3: "+m3);
            double total = Total(m1,m2,m3);
            double avg = Program.avg(m1, m2, m3);
            Console.WriteLine("Total: "+total);
            Console.WriteLine("Average: "+avg);
        }
        
        #endregion
    }
}