//-----------------------------------------------------------------​
//    <copyright file="Lesson.cs" company="IPCA">​
//     Copyright IPCA-EST. All rights reserved.​
//    </copyright>​
//    <date>25-09-2024</date>​
//    <time>21:00</time>​
//    <version>0.1</version>​
//    <author>Ernesto Casanova</author>​
//-----------------------------------------------------------------

namespace Lesson_3.Tests
{
    /// <summary>
    /// PersonTests class
    /// </summary>
    public class PersonTests
    {
        #region Methods Tests

        /// <summary>
        /// Test the default constructor
        /// </summary>
        public static void TestDefaultConstructor()
        {
            // Arrange & Act
            Person person = new Person();

            // Assert
            if (person.Age != 0 || person.Name != "")
            {
                throw new Exception("TestDefaultConstructor failed");
            }
            else
            {
                Console.WriteLine("TestDefaultConstructor passed");
            }
        }

        /// <summary>
        /// Test the parameterized constructor
        /// </summary>
        public static void TestParameterizedConstructor()
        {
            // Arrange & Act
            Person person = new Person(25, "John");

            // Assert
            if (person.Age != 25 || person.Name != "John")
            {
                throw new Exception("TestParameterizedConstructor failed");
            }
            else
            {
                Console.WriteLine("TestParameterizedConstructor passed");
            }
        }

        /// <summary>
        /// Test the GetAge method
        /// </summary>
        public static void TestGetAge()
        {
            // Arrange
            Person person = new Person(30, "Alice");

            // Act
            int age = person.GetAge();

            // Assert
            if (age != 30)
            {
                throw new Exception("TestGetAge failed");
            }
            else
            {
                Console.WriteLine("TestGetAge passed");
            }
        }

        /// <summary>
        /// Test the GetName method
        /// </summary>
        public static void TestGetName()
        {
            // Arrange
            Person person = new Person(30, "Alice");

            // Act
            string name = person.GetName();

            // Assert
            if (name != "Alice")
            {
                throw new Exception("TestGetName failed");
            }
            else
            {
                Console.WriteLine("TestGetName passed");
            }
        }

        /// <summary>
        /// Test the DisplayValue method
        /// </summary>
        public static void TestDisplayValue()
        {
            // Arrange
            Person person = new Person(30, "Alice");

            // Act & Assert
            Console.WriteLine("Expected Output: Name: Alice, Age: 30");
            Console.Write("Actual Output: ");
            person.DisplayValue();
        }

        /// <summary>
        /// Test the Name property setter
        /// </summary>
        public static void TestNameSetter()
        {
            // Arrange
            Person person = new Person();

            // Act
            person.Name = "Bob";

            // Assert
            if (person.Name != "Bob")
            {
                throw new Exception("TestNameSetter failed");
            }
            else
            {
                Console.WriteLine("TestNameSetter passed");
            }
        }

        /// <summary>
        /// Test the Age property setter
        /// </summary>
        public static void TestAgeSetter()
        {
            // Arrange
            Person person = new Person();

            // Act
            person.Age = 40;

            // Assert
            if (person.Age != 40)
            {
                throw new Exception("TestAgeSetter failed");
            }
            else
            {
                Console.WriteLine("TestAgeSetter passed");
            }
        }

        #endregion
    }
}