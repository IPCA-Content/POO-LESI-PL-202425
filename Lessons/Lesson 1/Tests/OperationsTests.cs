//-----------------------------------------------------------------​
//    <copyright file="Lesson.cs" company="IPCA">​
//     Copyright IPCA-EST. All rights reserved.​
//    </copyright>​
//    <date>25-09-2024</date>​
//    <time>21:00</time>​
//    <version>0.1</version>​
//    <author>Ernesto Casanova</author>​
//-----------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1.Tests
{
    /// <summary>
    /// OperationsTests class
    /// </summary>
    public class OperationsTests
    {
        #region Methods Tests

        /// <summary>
        /// Test the sum of two int numbers
        /// </summary>
        /// <exception cref="Exception"></exception>
        public static void OperationsTests_TestSum_ReturnInt()
        {
            // Arrange
            int a = 1;
            int b = 2;

            // Act
            int result = Operations.Sum(a, b);
            
            // Assert
            if (result != 3)
            {
                throw new Exception("TestSumDouble failed");
            } 
            else 
            {
                Console.WriteLine("TestSumDouble passed");
            }
        }

        /// <summary>
        /// Test the sum of two double numbers
        /// </summary>
        /// <exception cref="Exception"></exception>
        public static void OperationsTests_TestSum_ReturnDouble()
        {
            // Arrange
            double a = 1.0;
            double b = 2.0;

            // Act
            double result = Operations.Sum(a, b);

            // Assert
            if (result != 3)
            {
                throw new Exception("TestSumDouble failed");
            } 
            else 
            {
                Console.WriteLine("TestSumDouble passed");
            }
        }

        /// <summary>
        /// Test the subtraction of two numbers
        /// </summary>
        /// <exception cref="Exception"></exception>
        public static void OperationsTests_TestSub_ReturnSub()
        {
            // Arrange
            int a = 2;
            int b = 1;

            // Act
            int result = Operations.Sub(a, b);

            // Assert
            if (result != 1)
            {
                throw new Exception("TestSub failed");
            } 
            else 
            {
                Console.WriteLine("TestSub passed");
            }
        }
        #endregion
    }
}
