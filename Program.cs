using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_QA
{
    class Program
    {
        public static void Main(string[] args)
        {
            int userInput;
            bool checkStatus = true;
            int side1;
            int side2;
            int side3;
            do
            {
                bool sideCheck = true;
                Console.WriteLine("\n\n##Select from the mentioned menu\n");
                Console.WriteLine("1. Enter triangle dimensions");
                Console.WriteLine("2. Exit");

                try
                {
                    userInput = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Enter the input in Int Format.");
                    continue;
                }
                switch (userInput)
                {
                    case 1:

                        do
                        {
                            try
                            {
                                Console.WriteLine("Enter side 1");
                                side1 = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Enter side 2");
                                side2 = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Enter side 3");
                                side3 = Convert.ToInt32(Console.ReadLine());

                                if (((side1 + side2) > side3) && ((side2 + side3) > side1) && ((side1 + side3) > side2))
                                {
                                    Console.WriteLine("\nIt forms a triangle\n");
                                    Console.WriteLine("Triangle is : " + TriangleSolver.Analyze(side1, side2, side3));
                                }
                                else
                                {
                                    Console.WriteLine("It doesn't form a triangle");
                                }

                                checkStatus = true;
                                sideCheck = true;
                                break;
                            }
                           
                            catch (Exception e)
                            {
                                Console.WriteLine("\nEnter the side in Int format");
                                sideCheck = false;
                            }
                           
                        }
                        while (!sideCheck);
                        break;
                    case 2:
                        Console.WriteLine("\n\n##Exiting##");
                        checkStatus = false;
                        break;
                    default:
                        Console.WriteLine("Select the valid option 1 or 2 only.");
                        break;
                }
            } while (checkStatus);
        }
    }
}
