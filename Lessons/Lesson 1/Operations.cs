//-----------------------------------------------------------------​
//    <copyright file="Lesson.cs" company="IPCA">​
//     Copyright IPCA-EST. All rights reserved.​
//    </copyright>​
//    <date>19-09-2024</date>​
//    <time>21:00</time>​
//    <version>0.1</version>​
//    <author>Ernesto Casanova</author>​
//-----------------------------------------------------------------

namespace Lesson_1
{
    public class Operations
    {
        #region Functions
        /// <summary>
        /// Sum two numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>int</returns>
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Sum two numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>double</returns>
        public static double Sum(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Subtract two numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>int</returns>
        public static int Sub(int a, int b)
        {
            return a - b;
        }
        #endregion
    }
}
