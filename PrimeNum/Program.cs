using System;

namespace PrimeNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            for (int i=1;i<=num;i++)
            {
                if(num%i==0)
                {
                    a++;
                }
            }
            if(a==2)
            {
                Console.WriteLine(num+" is a prime number");
            }
            else
            {
                Console.WriteLine(num+" is not a prime number");
            }
        }
    }
}
