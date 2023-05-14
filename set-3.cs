using System;
using System.Management.Instrumentation;
using System.Xml;

namespace Question_Set1
{
    public class set_3
    {
        
        #region Get Number

        static int GetNumber(int a)
        {
            if (a == 1)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        public static void Sample()
        {
            int p1 = 0;
            int p2 = 0;
            int i = 1;
            while (i <= 5)
            {
                if (GetNumber(i)%2 != 0)
                {
                    p1 += 1;
                }
                else if(GetNumber(i)%2==0)
                {
                    p2 += 1;
                }

                i++;
            }

            Console.WriteLine("p1: "+p1);
            Console.WriteLine("p2: "+p2);
        }

        #endregion
        
        #region 1. Given N, print all numbers from 1 upto N.

        public static void PrintNumber(int Number)
        {
            int i = 0;
            while (i <= Number)
            {
                Console.Write(i+", ");
                i++;
            }   
        }

        #endregion

        #region 2. Given M, N, print all numbers from M upto N, where (M<N)

        public static void PrintNumber1(int M, int N)
        {
            while (M <= N)
            {
                Console.Write(M+", ");
                M++;
            }

            
        }

        #endregion

        #region 3. Given N, Print all even numbers from 1 upto N.

        public static void PrintEventNumbers(int Number)
        {
            int i = 2;
            while (i <= Number)
            {
                Console.Write(i+", ");
                i+=2;
            }
        }

        #endregion

        #region 4. Given N, Print all Odd numbers from 1 upto N.

        public static void PrintOddNumbers(int Number)
        {
            int i = 1;
            while (i <= Number)
            {
                Console.Write(i+", ");
                i += 2;
            }
        }

        #endregion

        #region 5. Given M, N print all even numbers from M upto N, where (M<N)

        public static void MNEvenNumber(int M, int N)
        {
            while (M<N+1)
            {
                Console.Write(M+", ");
                M += 2;
            }
        }

        #endregion

        #region 6. Given M, N print all odd numbers from M upto N, where M<N

        public static void MNOddNumber(int M, int N)
        {
            while (M < N + 1)
            {
                Console.Write(M+", ");
                M += 2;
            }
        }

        #endregion

        #region 7. Print all Numbers between 1 upto 100 that are divisible by a Given Number N.

        public static void DivN()
        {
            int i = 1;
            Console.Write("Enter the divisor number: ");
            int divisor = Convert.ToInt32(Console.ReadLine());
            while (i<100)
            {
                if (i == 1)
                {
                    i = divisor;
                    Console.Write(i+", ");
                }
                else
                {
                    Console.Write(i+", ");   
                }
                i+=divisor;
            }
        }

        #endregion

        #region #8. Display the multiplication Table upto 20 for a given value N.

        public static int TableForm(int rows, int multiplier, int sumValue)
        {
            int i = 1;
            
            while (i <= rows)
            {
                Console.WriteLine(i+" "+"*"+" "+multiplier+" "+"="+" "+"{0}",i*multiplier);
                sumValue += i * multiplier;
                i++;
            }

            return sumValue;
        }

        #endregion

        #region 9. Display the multiplication tables for 1,2,3,4 & 5 up to 20 rows in each. Format the output for better readability.

        public static void Tables()
        {
            int rows = 20;
            int multipler = 5;
            int i = 1;
            while (i<=multipler)
            {
                TableForm(rows, i, 0);
                Console.WriteLine("=============");
                i++;
            }

        }

        #endregion

        #region 10. Given N, print the sum of all numbers between 1 and N.

        public static int sumNumbers(int Number)
        {
            return (Number* (Number + 1) / 2);
        }

        #endregion

        #region Incremental by 2

        public static int Incrementalby2(int init, int end, int sum)
        {
            while (init <= end)
            {
                sum += init;
                init += 2;
            }

            return sum;
        }

        #endregion

        #region 11. Given N, print the sum of all even numbers between 1 and N.

        public static int sumEvenNumbers(int Number)
        {
            //return (Number * (Number + 1));
            int i = 1;
            int total = 0;
            if (i % 2 != 0)
            {
                i++;
                total = Incrementalby2(i, Number, total);
            }
            else 
            {
               total = Incrementalby2(i, Number, total);
            }
            
            return total;
        }

        #endregion

        #region 12. Given N, print the sum of all odd numbers between 1 and N.

        public static int sumOddNumbers(int Number)
        {
            int i = 2;
            int total = 0;
            if (i % 2 == 0)
            {
                i++;
                total = Incrementalby2(i, Number, total);
            }
            else
            {
                total = Incrementalby2(i, Number, total);
            }

            return total;
        }

        #endregion

        #region 13. Given K and N, print the sum of all multiples of K between 1 and N.

        public static void SumOfMultiple()
        {
            int SumofValues = 0;
            Console.Write("Enter the max rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of Multiplier: ");
            int k = Convert.ToInt32(Console.ReadLine());
            if (k > 0)
            {
                SumofValues = TableForm(rows,k, SumofValues);
            }

            Console.WriteLine("Sum of multiple value is: "+SumofValues);
        }

        #endregion

        #region 14. Given N, Write a program that prints Fizz if the number is a multiple of 3, Buzz if the number is a multiple of 5, FizzBuzz if the number is a multiple of 3 and 5, otherwise print the number upto N.

        public static void FizzBuzz()
        {
            Console.WriteLine("Enter the value of Maximum: ");
            int Max = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            
            while (i <= Max)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }

                i++;
            }
        }

        #endregion

        #region 15. Find the Factorial of a given number

        public static void FindFactorial()
        {
            Console.Write("Enter the value of number: ");
            int Number = Convert.ToInt32(Console.ReadLine());
            int i = 2;
            Console.Write(1+", ");
            while (Number/2 >= i)
            {
                if (Number % i == 0)
                {
                    Console.Write(i+", ");
                }
                i++;
            }
        }

        #endregion

        #region 16. Prompt the user for N, the number of subjects in the current semester.  Obtain N inputs corresponsing to the marks in each of those subjects and Output the Total and Average mark at the end.

        public static void PromptUser()
        {
            Console.Write("Enter the number of subjects: ");
            int NumberofSubjects = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            int total = 0;
            double avg = 0;
            while (NumberofSubjects >= i)
            {
                Console.Write("Enter the Marks for the subject {0}:", i);
                int marks = Convert.ToInt32(Console.ReadLine());
                total += marks;
                i++;
            }

            avg = total / NumberofSubjects;
            Console.WriteLine("Total Marks {0} obtained in {1}",total, NumberofSubjects);
            Console.WriteLine("Average {0}",avg);
        }

        #endregion

        #region 17. Prompt the User for N, the number rounds in a match and obtain the score for each of those rounds, print the running score after each round and the final total at the end.

        public static void PromptScore()
        {
            Console.Write("Enter the number of rounds: ");
            int NumberofRounds = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            int totalScore = 0;
            while (NumberofRounds > i)
            {
                Console.Write("Enter the score for the round {0}: ", i);
                int score = Convert.ToInt32(Console.ReadLine());
                totalScore += score;
                Console.WriteLine("Round: {0} and score: {1}", i,score);
                i++;
            }

            Console.WriteLine("Total score is {0} obtained in {1} rounds.",totalScore,NumberofRounds);
        }

        #endregion

        #region 18. Improve the menu driven calculator to get input for calculations continuously till the user types quit. After every calculation, ask the user to type Yes to continue or quit to exit.

        public static void MenuDrivenCalculator()
        {
            string choice = string.Empty;
            do
            {
                Console.Write("Enter the value of the first number: ");
                double Number1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the value of the second number: ");
                double Number2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the operator: ");
                string option = Console.ReadLine();
                double Result = 0;
                switch (option)
                {
                    case "+":
                        Result = Question_Set1.Program.addition(Number1, Number2);
                        break;
                    case "-":
                        Result = Question_Set1.Program.difference(Number1, Number2);
                        break;
                    case "*":
                        Result = Question_Set1.Program.multiply(Number1, Number2);
                        break;
                    case "/":
                        Result = Question_Set1.Program.division(Number1, Number2);
                        break;
                    // case "%":
                    //     Result = Question_Set1.Program.modulus(Number1, Number2);
                    //     break;
                    default:
                        Console.WriteLine("Given parameter is invalid");
                        break;
                }
                Console.WriteLine("Result is: "+Result);
                Console.WriteLine("Continue to enter yes");
                choice = Console.ReadLine();
            } while (choice.ToLower()=="yes");
            
        }

        #endregion

        #region 19. Improve the RPS game to get the number of rounds X to be played (odd number) from the user (X=3,5,7 or 9).
        //Play the game for X rounds or till one user wins more than (X/2)+1 rounds.  Maintain score for each user separately and based on the outcome of X rounds,
        //determine the output of the game - Draw, User Wins or AI wins.

        public static void RPS()
        {
            Console.Write("Enter the number of rounds: ");
            int rounds = Convert.ToInt32(Console.ReadLine());
            int p1count = 0;
            int p2count = 0;
            int matchTied = 0;
            int getWon = 0;
            if (rounds >= 1 && rounds%2!=0)
            {
                int i = 0;
                while (i < rounds)
                {
                    Random rand = new Random();
                    int randNumber = rand.Next(1, 4);
                    Console.WriteLine("Random generated number is: {0}",randNumber);
                    Console.Write("Please enter your choice number between 1 to 3: ");
                    int userInput = Convert.ToInt32(Console.ReadLine());
                    if (Set_2.Game1(randNumber, userInput, getWon) == 1)
                    {
                        p1count++;
                    }
                    else if (Set_2.Game1(randNumber, userInput, getWon) == 2)
                    {
                        p2count++;
                    }
                    else
                    {
                        matchTied++;
                    }

                    if (((rounds / 2) + 1) <= p1count)
                    {
                        Console.WriteLine("Player1 is the winner of the match and won by {0}",p1count);
                    }
                    else if (((rounds / 2) + 1) <= p2count)
                    {
                        Console.WriteLine("Player2 is the winner of the match and won by {0}",p2count);
                    }
                    i++;
                }
            }
        }

        #endregion

        #region 20. Implement a number guessing game where you prompt the user to guess a number between 1 and X and  
        //inform them whether the entered number is larger or smaller than the magic (random) number and the number of attempts they took to guess the magic number correctly.

        public static void MagicNumbers(int Min, int Max)
        {
            Random rand = new Random();
            int randNumber = rand.Next(Min, Max);
            Console.WriteLine(randNumber);
            int count = 0;
            while(Min <= Max)
            {
                Console.Write("Attempt number between from {0} to {1} = ", Min, Max);
                int attempt = Convert.ToInt32(Console.ReadLine());
                if (randNumber > attempt)
                {
                    Console.WriteLine("Entered number is smaller");
                    Min = attempt;
                    count++;
                    Min++;
                }
                else if (randNumber < attempt)
                {
                    Console.WriteLine("Entered number is larger");
                    Max = attempt;
                    count++;
                    Max--;
                }
                else
                {
                    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++");
                    Console.WriteLine("Wow... Magic number is found after {0} attempts",count+1);
                    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++");
                    break;
                }
            }
        }
        
        #endregion
    }
}