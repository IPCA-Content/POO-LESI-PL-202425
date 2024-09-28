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
    /// Data Types
    /// </summary>
    public class DataTypes
    {
        /// <summary>
        /// Data Types Playground
        /// </summary>
        public static void Playground()
        {
            #region Data Types

            // Some examples of data types

            // usigned 64 bit integer
            ulong likes = 10000000000000;
            Console.WriteLine($"Likes {likes}");

            //long
            long e = 1234567890L;
            Console.WriteLine($"long {e}");

            //short
            short f = 12345;
            Console.WriteLine($"short {f}");

            // double 
            double g = 5.8;
            Console.WriteLine($"double {g}");

            // float
            float h = 5.8f;
            Console.WriteLine($"float {h}");

            // decimal
            decimal l = 5.8m;
            Console.WriteLine($"decimal {l}");

            //uint
            uint m = 5;
            Console.WriteLine($"uint {m}");

            #endregion

            #region Data Types Conversion or Playground

            // Value types
            int a = 10;
            int b = a;
            b = 20;
            Console.WriteLine("a: " + a + " b: " + b);

            // Reference types
            int[] arr1 = new int[] { 1, 2, 3 };
            int[] arr2 = arr1;
            arr2[0] = 4;
            Console.WriteLine("arr1[0]: " + arr1[0] + " arr2[0]: " + arr2[0]);

            // Boxing and unboxing
            int i = 123;
            object o = i; // boxing
            int j = (int)o; // unboxing

            // Nullable types
            int? c = null;
            int d = c ?? 0;
            Console.WriteLine("c: " + c + " d: " + d);

            // Dynamic types
            dynamic dyn = 10;
            Console.WriteLine("dyn: " + dyn);
            dyn = "Hello";
            Console.WriteLine("dyn: " + dyn);

            #endregion
        }
    }
}
