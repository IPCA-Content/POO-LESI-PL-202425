//-----------------------------------------------------------------​
//    <copyright file="Lesson.cs" company="IPCA">​
//     Copyright IPCA-EST. All rights reserved.​
//    </copyright>​
//    <date>03-10-2024</date>​
//    <time>21:00</time>​
//    <version>0.1</version>​
//    <author>Ernesto Casanova</author>​
//-----------------------------------------------------------------

namespace Lesson_4
{
    /// <summary>
    /// Class Person
    /// </summary>
    public class Person
    {
        #region Private Properties
        private string name { get; set; }
        private int age { get; set; }
        #endregion

        #region Public Properties
        public string Name { get
            {
                return this.name;
            }
            set
            {
                if (value.Length > 0) // or another condition
                {
                    this.name = value;
                }
            }
        }
        public int Age { 
            // if (user has permissions to see the age)
            get { return this.age; } 
            set { this.age = value; } 
        }
        #endregion

        #region Constructors

        /// <summary>
        /// Class constructor without parameters
        /// </summary>
        public Person() {
            this.age = 0;
            this.name = "";
        }

        /// <summary>
        /// Class constructor with parameters
        /// </summary>
        /// <param name="age"></param>
        /// <param name="name"></param>
        public Person(string name, int age) {
            this.age = age;
            this.name = name;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Get the age of the person
        /// </summary>
        /// <returns></returns>
        public int GetAge() { return this.age; }

        /// <summary>
        /// Get the name of the person
        /// </summary>
        /// <returns></returns>
        public string GetName() { return this.name; }

        /// <summary>
        /// Display the values of the person
        /// </summary>
        public virtual void DisplayValue() {
            Console.WriteLine($"Name: {this.name}, Age: {this.age}");
        }

        /// <summary>
        /// Returns the values of the person
        /// </summary>
        public virtual string ReturnsValues()
        {
            return $"Name: {this.name}, Age: {this.age}";
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
