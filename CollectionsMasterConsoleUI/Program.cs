using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            var fif = new int[50];


            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            for (var i = 0; i < fif.Length; i++)
            {
                fif[i] = i + 1;
            }

            //TODO: Print the first number of the array

            Console.WriteLine(fif[0]);

            //TODO: Print the last number of the array
            //
            Console.WriteLine(fif[49]);

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(fif);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");

            Array.Reverse(fif);
            NumberPrinter(fif);

            Console.WriteLine("---------REVERSE CUSTOM------------");

            for (int i = 49; i <= 0; i++)
            {
                fif[i] = i - 1;
            }
            NumberPrinter(fif);

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            for (int i = 0; i < fif.Length; i++)
            {
                if (fif[i] % 3 == 0)
                {
                    fif[i] = 0;
                }
            }
            NumberPrinter(fif);


            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");

            Array.Sort(fif);
            NumberPrinter(fif);
            

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            var num = new List<int>();


            //TODO: Print the capacity of the list to the console
            Console.WriteLine(num.Capacity);


            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Random random = new Random();

            for (int i = 0; i < 50; i++)
            {
                int randomNumber = random.Next(0, 51);
                num.Add(randomNumber);
            }

            //TODO: Print the new capacity
            Console.WriteLine(num.Capacity);

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");

            string input = Console.ReadLine();
            int userNum = int.Parse(input);
            if (userNum <= 50)
            {
                Console.WriteLine("Pass.");
            }
            else
            {
                Console.Write("Error.");
            }
            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            foreach (int number in num)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            foreach (int number in num)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);

                }
            }

            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");

            for (int i = 0; i <= num.Count; i++)
            {
                if (num[i] % 2 == 0)
                {
                    num.Sort();
                    Console.WriteLine(num[i]);

                }
            }
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            var numArray = num.ToArray();


            //TODO: Clear the list
            num.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
      

        }

        private static void OddKiller(List<int> numberList)
        {
            
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();

        }        

        private static void ReverseArray(int[] array)
        {
            
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
