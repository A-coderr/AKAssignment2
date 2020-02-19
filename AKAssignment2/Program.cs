//Created by Anzhelika Kostyuk
//Date: February 15, 2020
//Purpose: Assignment 2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {

            bool begin = true;
            int user1 = 0;
            int user2 = 0;
            int user3 = 0;
            string result = "";
            do
            {
                Console.WriteLine("1. Enter triangle dimensions");
                Console.WriteLine("2. Exit");
                string input = Console.ReadLine();

                try
                {
                    int uinput = int.Parse(input);
                    if (uinput == 1)
                    {
                        bool uinput1 = true;
                        do
                        {
                            Console.Write("Enter First Number: ");
                            string num1 = Console.ReadLine();
                            try
                            {
                                user1 = Convert.ToInt32(num1);
                                if (user1 > 0)
                                {
                                    uinput1 = false;
                                }
                                else
                                {
                                    Console.WriteLine("Enter valid number (greater than 0)");
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Enter valid number (greater than 0)");
                            } 
                        } while (uinput1);

                        bool uinput2 = true;
                        do
                        {
                            Console.Write("Enter Second Number: ");
                            string num2 = Console.ReadLine();
                            try
                            {                                
                                user2 = int.Parse(num2);
                                if (user2 > 0)
                                {
                                    uinput2 = false;
                                }
                                else
                                {
                                    Console.WriteLine("Enter valid number (greater than 0)");
                                }                                
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Enter valid number (greater than 0)");
                            }
                        } while (uinput2);

                        bool uinput3 = true;
                        do
                        {
                            Console.Write("Enter Third Number: ");
                            string num3 = Console.ReadLine();
                            try
                            {
                                user3 = int.Parse(num3);
                                if (user3 > 0)
                                {
                                    uinput3 = false;
                                }
                                else
                                {
                                    Console.WriteLine("Enter valid number (greater than 0)");
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Enter valid number (greater than 0)");
                            }
                        } while (uinput3);

                        result = TriangleSolver.Analyze(user1, user2, user3);
                        Console.WriteLine(result);
                        Console.WriteLine();
                    }
                    else if (uinput == 2)
                    {
                        begin = false;
                    }
                    else
                    {
                        Console.WriteLine("Choose option 1 or 2");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Choose option 1 or 2");
                }
            } while (begin);


        }
    }
}
