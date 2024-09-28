//-----------------------------------------------------------------​
//    <copyright file="Lesson.cs" company="IPCA">​
//     Copyright IPCA-EST. All rights reserved.​
//    </copyright>​
//    <date>19-09-2024</date>​
//    <time>21:00</time>​
//    <version>0.1</version>​
//    <author>Ernesto Casanova</author>​
//-----------------------------------------------------------------
using Lesson_1;
using Lesson_1.Tests;

namespace Lesson
{
    /// <summary>
    /// Summary description for Lesson.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main function
        /// </summary>
        /// <param name="args">string[]</param>
        static void Main(string[] args)
        {
            double x = Operations.Sum(2.0, 3.0);
            Console.WriteLine($"Sum = {x}");

            int z = Operations.Sum(2, 3);
            Console.WriteLine($"Sum = {z}");

            OperationsTests.OperationsTests_TestSum_ReturnInt();
            OperationsTests.OperationsTests_TestSum_ReturnDouble();
            OperationsTests.OperationsTests_TestSub_ReturnSub();
        }
    }
}