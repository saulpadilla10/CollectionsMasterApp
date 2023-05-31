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

            Populater(fif);

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

            ReverseArray(fif);
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

            ThreeKiller(fif);
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
            Populater(num);

            //TODO: Print the new capacity
            Console.WriteLine(num.Capacity);

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            //Console.WriteLine("What number will you search for in the number list?");
            int userInput;
            bool present;

            do
            {
                Console.WriteLine("What number will you search for in the number list?");

                present = int.TryParse(Console.ReadLine(), out userInput);
             

            } while (present == false);

            NumberChecker(num, userInput);

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

            OddKiller(num);
            NumberPrinter(num);

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
            NumberPrinter(num);
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            var numArray = num.ToArray();


            //TODO: Clear the list
            num.Clear();

            #endregion
        }

            private static void ThreeKiller(int[] numbers)
            {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
          

        }

            private static void OddKiller(List<int> numberList)
            {
            foreach (int number in numberList)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);

                }

            }
        }

            private static void NumberChecker(List<int> numberList, int searchNumber)
            { 
           
            if (searchNumber <= 50)
            {
                Console.WriteLine("Pass.");
            }
            else
            {
                Console.Write("Error.");
            }


        }

        private static void Populater(List<int> numberList)
        {
            for (int i = 0; i < 50; i++)
            {
                Random random = new Random();
                var randomNumber = random.Next(0, 49);
                numberList.Add(randomNumber);
            }

        }

            private static void Populater(int[] numbers)
            {

                for (int i = 0; i < numbers.Length; i++)
                {
                    Random hit = new Random();
                    numbers[i] = hit.Next(0, 50);
                }

            }


            private static void ReverseArray(int[] array)
            {
            Array.Reverse(array);
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