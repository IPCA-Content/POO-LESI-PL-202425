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
    /// Exercises
    /// </summary>
    public class Exercises
    {
        #region Exercise

        /// <summary>
        /// Write a program that prints the numbers from 1 to 100.
        /// Prints "Fizz" for multiples of 3, "Buzz" for multiples of 5, 
        /// and "FizzBuzz" for multiples of both.
        /// </summary>
        public static void FizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        /// <summary>
        /// Reverse a string using while
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            int left = 0, right = s.Length - 1;
            while (left < right)
            {
                char temp = charArray[left];
                charArray[left] = charArray[right];
                charArray[right] = temp;
                left++;
                right--;
            }
            return new string(charArray);
        }

        /// <summary>
        /// Reverse a string using for loop
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ReverseStringForLoop(string s)
        {
            char[] charArray = s.ToCharArray();
            int length = s.Length;

            for (int i = 0; i < length / 2; i++)
            {
                char temp = charArray[i];
                charArray[i] = charArray[length - 1 - i];
                charArray[length - 1 - i] = temp;
            }

            return new string(charArray);
        }

        /// <summary>
        /// Reverse a string using for loop option 2
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ReverseStringForLoop2(string s)
        {
            char[] reversedArray = new char[s.Length];
            int length = s.Length;

            for (int i = 0; i < length; i++)
            {
                reversedArray[i] = s[length - 1 - i];
            }

            return new string(reversedArray);
        }

        /// <summary>
        /// Reverse a string using for loop option 3 (starting from the end)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ReverseStringForLoop3(string s)
        {
            char[] reversedArray = new char[s.Length];
            int length = s.Length;

            for (int i = length - 1; i >= 0; i--)
            {
                reversedArray[length - 1 - i] = s[i];
            }

            return new string(reversedArray);
        }

        /// <summary>
        /// Reverse a string using recursion and substring
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ReverseStringRecursive(string s)
        {
            if (s.Length <= 1)
                return s;

            return s[s.Length - 1] + ReverseString(s.Substring(0, s.Length - 1));
        }

        /// <summary>
        /// Reverse a string using char array and Array.Reverse
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ReverseStringWithClassArray(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        #endregion
    }
}
