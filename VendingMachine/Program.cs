using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Menu\n1.Vending Machine\n2.Exit");

            Console.WriteLine("Enter The option");

            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    VendingMachine.ReadInput();
                    break;
                case 2:
                    Console.WriteLine("Exited");
                    break;
                default:
                    Console.WriteLine("Enter the correct option");
                    break;
            }
        }
    }
}