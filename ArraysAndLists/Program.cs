﻿using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] myArray = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            List<int> odds = new List<int>();
            List<int> evens = new List<int>();
            foreach (int i in myArray)
                if (i % 2 == 0)
                {
                    evens.Add(i);
                }
                else
                {
                    odds.Add(i);
                }
           foreach (int i in evens)
            {
                Console.WriteLine($"{i} is an even number");
            }
           foreach (int i in odds)
            {
                Console.WriteLine($"{i} is an odd number");
            }
            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
        }
    }
}
