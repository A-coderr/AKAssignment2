﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGBAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();

            int radius = 0;
            int menuOption = 0;

            radius = GetRadiusFromUserInput(radius);

            do
            {
                do
                {
                    Console.WriteLine("1. Get Circle Radius");
                    Console.WriteLine("2. Change Circle Radius");
                    Console.WriteLine("3. Get Circle Circumference");
                    Console.WriteLine("4. Get Circle Area");
                    Console.WriteLine("5. Exit");
                    Console.WriteLine();

                    try
                    {
                        menuOption = int.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine("Wrong option, please select from the menu:");
                        Console.WriteLine();
                    }


                } while (menuOption == 0 || menuOption < 0 || menuOption > 5);

                switch (menuOption)
                {
                    case 1:
                        radius = circle.GetRadius();
                        Console.WriteLine("the radius value is now: " + radius);
                        Console.WriteLine();
                        break;
                    case 2:

                        radius = GetRadiusFromUserInput(radius);
                        circle.SetRadius(radius);
                        Console.WriteLine("the radius value is now: " + radius);
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("The circumference of the circle is: " + Math.Round(circle.GetCircumference(), 2));
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine("The Area of the circle is: " + Math.Round(circle.GetArea(), 2));
                        Console.WriteLine();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }

            } while (menuOption > 0 || menuOption < 5);
        }

        private static int GetRadiusFromUserInput(int radius)
        {
            do
            {
                Console.WriteLine("Please enter radius value: ");
                Console.WriteLine();

                try
                {
                    radius = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Not the correct format, please insert a int greater than zero!");
                    Console.WriteLine();
                }

            } while (radius == 0);
            return radius;
        }


    }

}
