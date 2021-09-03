using System;

namespace perfectNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0;
            Console.WriteLine("enter the number:");
            num = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<num;i++)
            {
                if(num%i==0)
                {
                    sum =sum+i;
                }
            }
            if(sum==num)
            {
                Console.WriteLine("number is a perfect number");
            }
            else
            {
                Console.WriteLine("number is not a perfect number" );
            }
        }
    }
}
