//-----------------------------------------------------------------​
//    <copyright file="Lesson.cs" company="IPCA">​
//     Copyright IPCA-EST. All rights reserved.​
//    </copyright>​
//    <date>25-09-2024</date>​
//    <time>21:00</time>​
//    <version>0.1</version>​
//    <author>Ernesto Casanova</author>​
//-----------------------------------------------------------------

namespace Lesson_2.Examples
{
    /// <summary>
    /// Conditions
    /// </summary>
    public class Conditions
    {
        /// <summary>
        /// Flow Control
        /// </summary>
        public static void Playground()
        {
            #region Flow Control

            // If condition
            int a = 10;
            int number = 5;
            if (a > number)
            {
                Console.WriteLine("a is greater than number");
            }
            else
            {
                Console.WriteLine("a is less than number");
            }

            // switch case
            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;
            }

            // Ternary operator
            int x = 10;
            int y = 5;
            int result = x > y ? x : y;
            Console.WriteLine($"Result: {result}");

            #endregion
        }
    }
}
