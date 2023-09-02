using System;
using System.Collections.Generic;

//Module Iteration Statements
//Exercise 2 
//Repo Name: ArraysAndListsProject

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] XRay = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            List<int> EvensList = new List<int>();
            List<int> OddList   = new List<int>();


            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            for (int i=0; i<XRay.Length; i++)
            {
                if (XRay[i] % 2 == 0)
                {
                    Console.WriteLine($"{XRay[i]} Is even");
                    EvensList.Add(XRay[i]);
                }
                if (XRay[i] % 2 != 0)
                {
                    Console.WriteLine($"{XRay[i]} Is odd");
                    OddList.Add(XRay[i]);
                }

            }

            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            foreach (int tmpInt in EvensList)
            {
                Console.WriteLine($"{tmpInt} Is even");
            }
            foreach (int tmpInt in OddList)
            {
                Console.WriteLine($"{tmpInt} Is odd");
            }
        }
    }
}
