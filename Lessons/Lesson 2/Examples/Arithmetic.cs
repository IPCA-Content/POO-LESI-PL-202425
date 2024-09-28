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
    /// Arithmetic operations and variables declaration
    /// </summary>
    public class Arithmetic
    {
        /// <summary>
        /// Operations
        /// </summary>
        public static void Playground()
        {
            #region Arithmetic Operations

            int a = 10;
            int b = 5;

            // Addition
            int c = a + b;
            Console.WriteLine($"Addition {c}");

            // Subtraction
            int sub = a - b;
            Console.WriteLine($"Sub {sub}");

            // Mulpl
            int mult = a * b;
            Console.WriteLine($"Mult {mult}");

            // Div  
            int div = a / b;
            Console.WriteLine($"Div {div}");

            // Mod
            int reminder = a % b;
            Console.WriteLine($"Reminder {reminder}");

            // Increment
            a++; // a = a + 1
            Console.WriteLine($"Increment {a}");

            // Decrement
            b--; // b = b - 1
            Console.WriteLine($"Decrement {b}");

            // Compound assignment increment
            a += b; // a = a + b
            Console.WriteLine($"Compound assignment {a}");

            // Compound assignment decrement
            a -= b; // a = a - b
            Console.WriteLine($"Compound assignment {a}");

            // Compound assignment multiplication
            a *= b; // a = a * b
            Console.WriteLine($"Compound assignment {a}");

            // Compound assignment division
            a /= b; // a = a / b    
            Console.WriteLine($"Compound assignment {a}");

            // Compound assignment modulus
            a %= b; // a = a % b
            Console.WriteLine($"Compound assignment {a}");

            // left shift
            int value = 5; // 0101 in binary
            int result = value << 1; // 1010 in binary, which is 10
            Console.WriteLine($"Left Shift: {value} << 1 = {result}");

            // right shift
            int value2 = 20; // 10100 in binary
            int result2 = value2 >> 2; // 0101 in binary, which is 5
            Console.WriteLine($"Right Shift: {value2} >> 2 = {result2}");

            // bitwise AND
            int value3 = 10; // 1010 in binary
            int result3 = 12 & value3; // 1000 in binary, which is 8
            Console.WriteLine($"Bitwise AND: 12 & {value3} = {result3}");

            // And more...
            // bitwise OR
            // bitwise XOR
            // bitwise NOT
            // logical AND
            // logical OR
            // logical XOR
            // logical NOT

            #endregion
        }
    }
}
