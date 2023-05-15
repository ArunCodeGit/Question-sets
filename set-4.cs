using System;
using System.Runtime.InteropServices;
using System.Xml;

namespace Question_Set1
{
    public class set_4
    {
        #region 1.Find out all factors of N

        public static void FindFactorial()
        {
            Console.WriteLine("Enter the value of N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int i = 2;
            Console.Write(1+", ");
            while (N/2 >= i)
            {
                if (N % i == 0)
                {
                    Console.Write(i+", ");
                }
                i++;
            }
            Console.Write(N);
        }

        #endregion

        #region 2. Find if the given number is prime or not

        public static bool IsPrime(int N)
        {
            bool IsPrime = false;
            int count = 0;
            int i = 2;
            
            while (N/2 >= i)
            {
                if (N % i == 0)
                {
                    count++;
                    break;
                }

                i++;
            }

            if (count == 0)
            {
                IsPrime = true;
            }
            else
            {
                IsPrime = false;
            }

            return IsPrime;
        }

        #endregion

        #region 3. Print all prime numbers from 1 to N

        public static void PrintAllPrime()
        {
            Console.Write("Enter the value of N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i < N)
            {
                if (IsPrime(i))
                {
                    Console.Write(i+", ");
                    i++;
                }
                else
                {
                    i++;
                }
            }
        }

        #endregion

        #region 4. Print the first "N" prime numbers starting from 2.

        public static void FirstNPrime()
        {
            Console.Write("Enter the value of N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int i = 1;
            while (i <= i+1)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + ", ");
                    i++;
                    count++;
                    if (count == N)
                    {
                        break;
                    }
                }
                else
                {
                    i++;
                }
            }
        }

        #endregion

        #region 5. Find the number of prime numbers less than or equal to "N"

        public static void PrimelessthanN()
        {
            Console.Write("Enter the value of N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int i = 2;
            while (i <= N)
            {
                if (IsPrime(i))
                {
                    Console.Write(i+", ");
                    i++;
                }
                else
                {
                    i++;
                }
            }
        }

        #endregion

        #region 6. Find the sum of first N prime numbers

        public static void SumOfFirstNPrime()
        {
            Console.Write("Enter the value of N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int sum = 0;
            int i = 1;
            while (i <= i + 1)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + ", ");
                    sum += i;
                    i++;
                    count++;
                    if (count == N)
                    {
                        break;
                    }
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine("Sum of all prime number is: " + sum);
        }

        #endregion

        #region 7. Find the sum of all prime numbers less than N

        public static void SumOfAllPrimeNumbers()
        {
            Console.Write("Enter the value of N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            int sum = 0;
            while (i <= N)
            {
                if (IsPrime(i))
                {
                    Console.Write(i+", ");
                    sum += i;
                    i++;
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine("Sum of all prime number is: " + sum);
        }

        #endregion

        #region 8. Print all prime numbers between m and n.  Assume m is always less than n.

        public static void PrimeMN()
        {
            Console.Write("Enter the value of M: ");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            while (M < N)
            {
                if (IsPrime(M))
                {
                    Console.Write(M+", ");
                    M++;
                }
                else
                {
                    M++;
                }
            }
        }

        #endregion

        #region 9. Print the prime factors of a given number N

        public static void PrimeFactor()
        {
            Console.WriteLine("Enter the value of N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int d = 2;
            while (N>1)
            {
                if (N % d == 0)
                {
                    int x = 0;
                    while (N % d == 0)
                    {
                        N /= d;
                        x++;
                    }
                    Console.WriteLine("{0} is prime factor and {1} times",d,x);
                }
                d++;
            }
        }

        #endregion

        #region 10. Find out number of prime numbers between "m" and "n".  Assume m is always less than n

        public static void FindPrimeMN(int M, int N)
        {
            int count = 0;
            if (M <= N)
            {
                while (M<=N)
                {
                    if (IsPrime(M))
                    {
                        count++;
                    }
                    M++;
                }
            }
            else
            {
                Console.WriteLine("M is greater than N.");
            }
            Console.WriteLine("{0} prime numbers found.",count);
        }

        #endregion

        #region 11. Print all prime numbers between m and n.  Assume m is greater than n

        public static void PrintPrimeMN(int M,int N)
        {
            int count = 0;
            if (M >= N)
            {
                while (M >= N)
                {
                    if (IsPrime(N))
                    {
                        Console.Write(N+", ");
                        count++;
                    }
                    N++;
                }
            }
            else
            {
                Console.Write("M is less than N!!!");
            }
        }

        #endregion

        #region 12. Find out number of prime numbers between "m" and "n".  Assume m is greater than n

        public static void FindPrimeMN1(int M, int N)
        {
            int count = 0;
            if (M >= N)
            {
                while (M >= N)
                {
                    if (IsPrime(N))
                    {
                        count++;
                    }
                    N++;
                }
                Console.WriteLine("{0} prime numbers found.",count);
            }
            else
            {
                Console.Write("M is less than N!!!");
            }
        }

        #endregion

        #region 13. What if "m" is an Even number

        public static void MEven(int M, int N)
        {
            int count = 0;
            if (M >= N)
            {
                while (M >= N)
                {
                    if (IsPrime(N))
                    {
                        Console.WriteLine(N+", ");
                        count++;
                    }

                    N++;
                }

                Console.WriteLine("{0} prime numbers found.", count);
            }
            else
            {
                Console.Write("M is less than N!!!");
            }
        }

        #endregion

        #region 14. What if "m" is an ODD Number

        public static void MOdd(int M, int N)
        {
            int count = 0;
            if (M >= N)
            {
                while (M >= N)
                {
                    if (IsPrime(N))
                    {
                        Console.WriteLine(N+", ");
                        count++;
                    }

                    N++;
                }

                Console.WriteLine("{0} prime numbers found.", count);
            }
            else
            {
                Console.Write("M is less than N!!!");
            }
        }

        #endregion

        #region 15. Find the next prime number given a number

        public static bool nextprimeBool(int N)
        {
            while(!IsPrime(N))
            {
                N++;
            }
            return true;
        }
        
        public static int nextprimeInt(int N)
        {
            while(!IsPrime(N))
            {
                N++;
            }
            
            Console.WriteLine("Next prime number is: {0}",N);
            return N;
        }

        #endregion

        #region 16. Find the previous prime number given a number

        public static bool PreviousPrimeBool(int N)
        {
            while (!IsPrime(N))
            {
                N--;
            }

            Console.WriteLine("Previous prime number is: {0}",N);
            return true;
        }
        
        public static int PreviousPrimeInt(int N)
        {
            while (!IsPrime(N))
            {
                N--;
            }

            Console.WriteLine("Previous prime number is: {0}",N);
            return N;
        }

        #endregion

        #region 17. Find the nearest prime number given a number

        public static void nearestPrime(int N)
        {
            int PP_N = N-PreviousPrimeInt(N);
            int NP_N = nextprimeInt(N) - N;
            if (PP_N < NP_N)
            {
                Console.WriteLine("Nearest prime number is: {0}",PreviousPrimeInt(N));
            }
            else if(PP_N>NP_N)
            {
                Console.WriteLine("Nearest prime number is: {0}",nextprimeInt(N));
            }
            else
            {
                Console.WriteLine("Both are same and Nearest prime number is: {0}",PreviousPrimeInt(N));
            }
        }

        #endregion

        #region 18. Find the kth prime number from a given number

        public static void KthPrimeNumber(int N, int K)
        {
            while (N>2)
            {
                if (!IsPrime(N))
                {
                    N++;
                }
                else
                {
                    Console.WriteLine("N={0}, K={1}",N,K);
                    if (K == 1)
                    {
                        Console.WriteLine("Kth prime number is: {0}", N);
                        break;
                    }
                    N++;
                    K--;
                }
            }
        }

        #endregion

        #region 19. Check if there exists a prime number in the range between M and N

        public static void FindExistsPrime(int M, int N)
        {
            if (M <= N)
            {
                while (M<=N)
                {
                    if (IsPrime(M))
                    {
                        Console.WriteLine("Yes, Prime number is exists in the given range M<=N.");
                        break;
                    }
                    else
                    {
                        M++;
                    }
                }
            }
            else if(M>=N)
            {
                while (M>=N)
                {
                    if (IsPrime(N))
                    {
                        Console.WriteLine("Yes, Prime number is exists in the given range M>=N");
                        break;
                    }
                    else
                    {
                        N++;
                    }
                }
            }
            else
            {
                Console.WriteLine("Please enter the valid number.");
            }
        }

        #endregion

        #region 20. Find the number which has the maximum number of distinct prime factors in the range M to N.

        public static void DistinctPrimeFactor(int M, int N)
        {
            int maxCount = 0;
            int ActualValue = 0;
            while (M <= N)
            {
                int Temp = M;
                int d = 2;
                int count = 0;
                while (Temp != 1)
                {
                    
                    if (Temp % d == 0)
                    {
                        Console.Write(d+", ");
                        Temp /= d;
                        count++;
                    }
                    else
                    {
                        d++;
                    }
                }
                
                if (maxCount < count)
                {
                    maxCount = count;
                    ActualValue = M;
                }
                M++;
            }

            Console.WriteLine("{0} got max distinct prime factors count is: {1}",M,maxCount);
        }

        #endregion

        #region 21. Check if the number N can be represented as the product of any two prime numbers

        public static void ProductofPrime(int N)
        {
            int N1 = 2;
            int N2 = 2;
            bool status = false;
            while (N1 >= 2)
            {
                N2 = 2;
                while (N / 2 != N2)
                {
                    if (N == N1 * N2 && (IsPrime(N1)==true) && (IsPrime(N2)==true))
                    {
                        status = true;
                        //Console.WriteLine("{0} is product of prime number and prime numbers are {1}*{2}.",N,N1,N2);
                        break;
                    }
                    else if (N1 * N2 >= N)
                    {
                        status = false;
                        break;
                    }
                    else
                    {
                        N2++;
                    }
                }

                if (status == true)
                {
                    break;
                }
                else
                {
                    N1++;   
                }
            }
            if (status == true)
            {
                Console.WriteLine("{0} is product of prime number and prime numbers are {1}*{2}.",N,N1,N2);
            }
            else if (status == false)
            {
                Console.WriteLine("Unable to found product of prime number in the given number {0}", N);
            }
            else
            {
                Console.WriteLine("Thank you!!!");
            }
        }

        #endregion

        #region 22. Check if the number N can be represented as the product of two distinct/unique prime numbers

        public static void DistinctUnique(int N)
        {
            int N1 = 2;
            int N2 = 2;
            bool status = false;
            if (IsPrime(N) == false)
            {
                while (N1 >= 2)
                {
                    N2 = 2;
                    while (N / 2 != N2)
                    {
                        if (N == N1 * N2 && (IsPrime(N1)==true) && (IsPrime(N2)==true))
                        {
                            status = true;
                            //Console.WriteLine("{0} is product of prime number and prime numbers are {1}*{2}.",N,N1,N2);
                            break;
                        }
                        else if (N1 * N2 >= N)
                        {
                            status = false;
                            break;
                        }
                        else
                        {
                            N2++;
                        }
                    }

                    if (status == true)
                    {
                        break;
                    }
                    else
                    {
                        N1++;   
                    }
                }
                if (status == true)
                {
                    Console.WriteLine("{0} is product of prime number and prime numbers are {1}*{2}.",N,N1,N2);
                }
                else if (status == false)
                {
                    Console.WriteLine("Unable to found product of prime number in the given number {0}", N);
                }
                else
                {
                    Console.WriteLine("Thank you!!!");
                }
            }
            else
            {
                Console.WriteLine("Given number is prime number: {0}", N);   
            }
        }

        #endregion

        #region 23. Represent the given number N as a product of prime numbers

        public static void ProductPrime(int N)
        {
            int N1 = 2;
            int N2 = 2;
            bool status = false;
            while (N1 >= 2)
            {
                N2 = 2;
                while (N / 2 != N2)
                {
                    if (N == N1 * N2 && (IsPrime(N1)==true) && (IsPrime(N2)==true))
                    {
                        status = true;
                        N2++;
                        break;
                    }
                    else if (N1 * N2 >= N)
                    {
                        status = false;
                        break;
                    }
                    else
                    {
                        N2++;
                    }
                }

                if (status == true)
                {
                    break;
                }
                else
                {
                    N1++;   
                }
            }
            if (status == true)
            {
                Console.WriteLine("{0} is product of prime number and prime numbers are {1}*{2}.",N,N1,N2);
            }
            else if (status == false)
            {
                Console.WriteLine("Unable to found product of prime number in the given number {0}", N);
            }
            else
            {
                Console.WriteLine("Thank you!!!");
            }
        }

        #endregion

        #region 24. Find the largest prime number in a given range between M and N

        public static void LargestPrime(int M, int N)
        {
            int LargePrime = int.MinValue;
            while (M <= N)
            {
                if (IsPrime(M)==true && LargePrime <= M)
                {
                    LargePrime = M;
                    M++;
                }
                else
                {
                    M++;
                }
            }
            Console.WriteLine("Largest Prime number is: {0}",LargePrime);
        }

        #endregion

        #region 25. Find the smallest prime number in the given range between M and N.

        public static void SmallestPrime(int M, int N)
        {
            int SmallPrime = int.MaxValue;
            while (M <= N)
            {
                if (IsPrime(M) == true && SmallPrime >= M)
                {
                    SmallPrime = M;
                    M++;
                }
                else
                {
                    M++;
                }
            }

            Console.WriteLine("Smallest Prime number is: {0}", SmallPrime);
        }

        #endregion
    }
}