/*
 * Program.cs
 * Assignment2
 * 
 *  Revision History
 *      Jeonghwan Ju, 2020.02.25: Created
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JJAssignment2
{
    /// <summary>
    /// Main Program class
    /// </summary>
    class Program
    {
        // Declaring class variables and contants
        private const int DIMENSIONS_COUNT = 3;

        private static int[] dimensioins = new int[DIMENSIONS_COUNT];

        /// <summary>
        /// Display Menu
        /// </summary>
        public static void DisplayMenu()
        {
            // Display menu lists
            Console.WriteLine();
            Console.WriteLine("========================================");
            Console.WriteLine("**** Menu ****");
            Console.WriteLine("1. Enter triangle dimensions");
            Console.WriteLine("2. Exit");
            Console.Write("Enter the menu number[1,2]: ");
        }

        /// <summary>
        /// Input Triangle's Dimensions' value
        /// </summary>
        public static void InputDimensions()
        {
            // Display 'input title'
            Console.WriteLine();
            Console.WriteLine("========================================");
            Console.WriteLine("**** Input Dimensions of Triangle ****");


            bool checkValid = false;
            string inputValue = "";

            for (int i = 0; i < DIMENSIONS_COUNT; i++)
            {
                do
                {
                    // Display menu lists
                    Console.Write($"Enter the dimension value ({i + 1} / {DIMENSIONS_COUNT}): ");

                    try
                    {
                        inputValue = Console.ReadLine();
                        dimensioins[i] = int.Parse(inputValue);
                        checkValid = true;

                        // check value
                        if (dimensioins[i] <= 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("You must enter integer greater than 0.");
                            Console.WriteLine("Your input: " + inputValue);
                            Console.WriteLine();
                            checkValid = false;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine();
                        Console.WriteLine("You must enter integer number.");
                        Console.WriteLine("Your input: " + inputValue);
                        Console.WriteLine();
                        checkValid = false;
                    }
                } while (!checkValid);
            } // for (int i = 0; i < DIMENSIONS_COUNT; i++)
        }

        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Display title
            Console.WriteLine();
            Console.WriteLine("========================================");
            Console.WriteLine("PROG2070 Quality Assurance Assignment 02");
            Console.WriteLine("Name: Jeonghwan Ju");
            Console.WriteLine("========================================");
            Console.WriteLine();

            bool exitProgram = false;
            string menuInput = "";

            do
            {
                // Display Menu
                DisplayMenu();

                menuInput = Console.ReadLine().Trim();

                switch (menuInput)
                {
                    case "1":
                        InputDimensions();  // Input Triangle's Dimensions' value
                        Console.WriteLine();
                        Console.WriteLine("Result: " + TriangleSolver.Analyze(
                            dimensioins[0], dimensioins[1], dimensioins[2]));
                        Console.WriteLine();
                        break;

                    case "2":
                        exitProgram = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Please enter '1'or'2'.");
                        Console.WriteLine("Your input: " + menuInput);
                        Console.WriteLine();
                        break;
                }
            } while (!exitProgram);
        }
    }
}
