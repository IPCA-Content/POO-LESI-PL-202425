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
    /// Loops
    /// </summary>
    public class Loops
    {
        /// <summary>
        /// Loops Playground
        /// </summary>
        public static void Playground()
        {
            #region Loops

            // for loop
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            // infinite loop (while)
            while (true)
            {
                Console.WriteLine("");
                if (true)
                {
                    break;
                }
            }

            // infinite loop (for)
            for (; ; )
            {
                Console.WriteLine("");
                if (true)
                {
                    break;
                }
            }

            // do while loop
            int j = 10;
            do
            {
                Console.WriteLine(j);
                j--;
            } while (j > 0);

            #endregion
        }
    }
}
