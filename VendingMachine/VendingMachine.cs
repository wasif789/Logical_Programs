using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    class VendingMachine
    {
        public static void ReadInput()
        {
            int amount;
            Console.WriteLine("Enter the amount");
            amount = Convert.ToInt32(Console.ReadLine());
            GetMinimumNotes(amount);


        }

        //method for get minimum notes
        private static void GetMinimumNotes(int amount)
        {
            //Notes array carries demoninations
            int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };

            //this array counts number of notes
            int[] count = new int[notes.Length];

            //to calculate notes required
            for (int i = 0; i < notes.Length - 1; i++)
            {
                if (amount >= notes[i])
                {
                    count[i] = amount / notes[i];
                    amount -= (count[i] * notes[i]);
                }
            }
            Console.WriteLine($"Total Notes Required are : {count.Length}");
            Console.WriteLine("The notes are:");
            //To print notes
            for (int i = 0; i < notes.Length - 1; i++)
            {
                if (count[i] != 0)
                {
                    Console.WriteLine($"{count[i]} --> Rs.{notes[i]} Required");
                }
            }

        }
    }
}
