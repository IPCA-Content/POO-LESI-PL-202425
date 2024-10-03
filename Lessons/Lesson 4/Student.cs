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
    /// Class Student inherits from Person
    /// </summary>
    public class Student: Person
    {
        #region Private properties
        public string studentId { get; set; }
        public string course { get; set; }
        #endregion

        #region Public properties
        public string StudentId { 
            get { return this.studentId; } 
            set { this.studentId = value; } 
        }
        public string Course { 
            get { return this.course; } 
            set { this.course = value; } 
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Student class constructor without parameters
        /// </summary>
        public Student()
        {
            StudentId = "";
            Course = "";
        }

        /// <summary>
        /// Student class constructor with parameters
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="studentId"></param>
        /// <param name="course"></param>
        public Student(string name, int age, string studentId, string course)
            : base(name, age) // Correctly call the base constructor
        {
            StudentId = studentId;
            Course = course;
        }

        /// <summary>
        /// Construtor without calling base constructor
        /// </summary>
        //public Student(string name, int age, string studentId, string course)
        //{
        //    Name = name;
        //    Age = age;
        //    StudentId = studentId;
        //    Course = course;
        //}

        #endregion

        #region Public Methods
        /// <summary>
        /// Display the values of the student and from the person
        /// </summary>
        public override void DisplayValue()
        {
            base.DisplayValue();
            Console.WriteLine($"Student ID: {StudentId}, Course: {Course}");
        }

        /// <summary>
        /// Returns the values of the student and the person
        /// </summary>
        /// <returns></returns>
        public override string ReturnsValues()
        {
            return $"{base.ReturnsValues()} Student ID: {StudentId}, Course: {Course}";
        }
        #endregion

        #region Destructor  

        /// <summary>
        /// Destructor
        /// </summary>
        ~Student()
        {
            Console.WriteLine("Destructor called");
        }

        #endregion
    }
}
