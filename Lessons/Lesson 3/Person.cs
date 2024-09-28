//-----------------------------------------------------------------​
//    <copyright file="Lesson.cs" company="IPCA">​
//     Copyright IPCA-EST. All rights reserved.​
//    </copyright>​
//    <date>25-09-2024</date>​
//    <time>21:00</time>​
//    <version>0.1</version>​
//    <author>Ernesto Casanova</author>​
//-----------------------------------------------------------------

namespace Lesson_3
{
    /// <summary>
    /// Class Person
    /// </summary>
    public class Person
    {
        // Naming conventions:
        // https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/identifier-names

        #region Private Properties
        private string _name { get; set; }
        private int _age { get; set; }
        #endregion

        #region Public Properties
        public string Name { get
            {
                return this._name;
            }
            set
            {
                if (value.Length > 0) // or another condition
                {
                    this._name = value;
                }
            }
        }
        public int Age { 
            // if (user has permissions to see the age)
            get { return this._age; } 
            set { this._age = value; } 
        }
        #endregion

        #region Constructors

        /// <summary>
        /// Class constructor without parameters
        /// </summary>
        public Person() {
            this._age = 0;
            this._name = "";
        }

        /// <summary>
        /// Class constructor with parameters
        /// </summary>
        /// <param name="age"></param>
        /// <param name="name"></param>
        public Person(int age, string name) {
            this._age = age;
            this._name = name;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Get the age of the person
        /// </summary>
        /// <returns></returns>
        public int GetAge() { return this._age; }

        /// <summary>
        /// Get the name of the person
        /// </summary>
        /// <returns></returns>
        public string GetName() { return this._name; }

        /// <summary>
        /// Display the values of the person
        /// </summary>
        public void DisplayValue() {
            Console.WriteLine($"Name: {this._name}, Age: {this._age}");
        }

        #endregion

        #region Destructor  

        /// <summary>
        /// Destructor
        /// </summary>
        ~Person() {
            Console.WriteLine("Destructor called");
        }
        
        #endregion

    }
}
