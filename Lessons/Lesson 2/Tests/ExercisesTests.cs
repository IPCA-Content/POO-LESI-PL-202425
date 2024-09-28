using Lesson_2.Examples;

namespace Lesson_2.Tests
{
    /// <summary>
    /// ExercisesTests class
    /// </summary>
    public class ExercisesTests
    {
        #region Methods Tests

        /// <summary>
        /// Test the FizzBuzz method
        /// </summary>
        public static void ExercisesTests_TestFizzBuzz()
        {
            // Since FizzBuzz prints directly to the console, we will just call it here.
            // You can manually verify the output.
            Console.WriteLine("Testing FizzBuzz:");
            Exercises.FizzBuzz();
            Console.WriteLine();
        }

        /// <summary>
        /// Test the ReverseString method
        /// </summary>
        /// <exception cref="Exception"></exception>
        public static void ExercisesTests_TestReverseString_ReturnString()
        {
            // Arrange
            string input = "hello";
            string expected = "olleh";

            // Act
            string result = Exercises.ReverseString(input);

            // Assert
            if (result != expected)
            {
                throw new Exception("TestReverseString failed");
            }
            else
            {
                Console.WriteLine("TestReverseString passed");
            }
        }

        /// <summary>
        /// Test the ReverseStringForLoop method
        /// </summary>
        /// <exception cref="Exception"></exception>
        public static void ExercisesTests_TestReverseStringForLoop_ReturnsString()
        {
            // Arrange
            string input = "world";
            string expected = "dlrow";

            // Act
            string result = Exercises.ReverseStringForLoop(input);

            // Assert
            if (result != expected)
            {
                throw new Exception("TestReverseStringForLoop failed");
            }
            else
            {
                Console.WriteLine("TestReverseStringForLoop passed");
            }
        }

        /// <summary>
        /// Test the ReverseStringForLoop2 method
        /// </summary>
        /// <exception cref="Exception"></exception>
        public static void ExercisesTests_TestReverseStringForLoop2_ReturnsString()
        {
            // Arrange
            string input = "example";
            string expected = "elpmaxe";

            // Act
            string result = Exercises.ReverseStringForLoop2(input);

            // Assert
            if (result != expected)
            {
                throw new Exception("TestReverseStringForLoop2 failed");
            }
            else
            {
                Console.WriteLine("TestReverseStringForLoop2 passed");
            }
        }

        /// <summary>
        /// Test the ReverseStringForLoop3 method
        /// </summary>
        /// <exception cref="Exception"></exception>
        public static void ExercisesTests_TestReverseStringForLoop3_ReturnsString()
        {
            // Arrange
            string input = "test";
            string expected = "tset";

            // Act
            string result = Exercises.ReverseStringForLoop3(input);

            // Assert
            if (result != expected)
            {
                throw new Exception("TestReverseStringForLoop3 failed");
            }
            else
            {
                Console.WriteLine("TestReverseStringForLoop3 passed");
            }
        }

        /// <summary>
        /// Test the ReverseStringRecursive method
        /// </summary>
        /// <exception cref="Exception"></exception>
        public static void ExercisesTests_TestReverseStringRecursive_ReturnsString()
        {
            // Arrange
            string input = "recursion";
            string expected = "noisrucer";

            // Act
            string result = Exercises.ReverseStringRecursive(input);

            // Assert
            if (result != expected)
            {
                throw new Exception("TestReverseStringRecursive failed");
            }
            else
            {
                Console.WriteLine("TestReverseStringRecursive passed");
            }
        }

        /// <summary>
        /// Test the ReverseStringWithClassArray method
        /// </summary>
        /// <exception cref="Exception"></exception>
        public static void ExercisesTests_TestReverseStringWithClassArray_ReturnsString()
        {
            // Arrange
            string input = "array";
            string expected = "yarra";

            // Act
            string result = Exercises.ReverseStringWithClassArray(input);

            // Assert
            if (result != expected)
            {
                throw new Exception("TestReverseStringWithClassArray failed");
            }
            else
            {
                Console.WriteLine("TestReverseStringWithClassArray passed");
            }
        }

        #endregion
    }
}
