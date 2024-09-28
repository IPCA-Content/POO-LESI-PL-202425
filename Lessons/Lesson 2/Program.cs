//-----------------------------------------------------------------​
//    <copyright file="Lesson.cs" company="IPCA">​
//     Copyright IPCA-EST. All rights reserved.​
//    </copyright>​
//    <date>25-09-2024</date>​
//    <time>21:00</time>​
//    <version>0.1</version>​
//    <author>Ernesto Casanova</author>​
//-----------------------------------------------------------------
using Lesson_2.Examples;
using Lesson_2.Tests;

namespace Lesson_2
{
    /// <summary>
    /// Summary description for Lesson. 
    /// Aritmetic operations and variables declaration
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main function
        /// </summary>
        /// <param name="args">string[]</param>
        static void Main(string[] args)
        {
            DataTypes.Playground();

            Arithmetic.Playground();

            Conditions.Playground();

            Loops.Playground();

            #region Exercises

            Exercises.FizzBuzz();

            string value = Exercises.ReverseString("today");
            Console.WriteLine(value);

            string value2 = Exercises.ReverseStringForLoop3("today");
            Console.WriteLine(value2);

            // Run FizzBuzz unit test
            ExercisesTests.ExercisesTests_TestFizzBuzz();

            // Run string reversal unit tests
            ExercisesTests.ExercisesTests_TestReverseString_ReturnString();
            ExercisesTests.ExercisesTests_TestReverseStringForLoop_ReturnsString();
            ExercisesTests.ExercisesTests_TestReverseStringForLoop2_ReturnsString();
            ExercisesTests.ExercisesTests_TestReverseStringForLoop3_ReturnsString();
            ExercisesTests.ExercisesTests_TestReverseStringRecursive_ReturnsString();
            ExercisesTests.ExercisesTests_TestReverseStringWithClassArray_ReturnsString();
            #endregion

        }
    }
}