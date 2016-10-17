using RepoQuiz.Models;
using System;
using System.Collections.Generic;

namespace RepoQuiz.DAL
{
    public class StudentBuilder
    {
        public Student Student1 { get; set; }
        public Student Student2 { get; set; }
        public Student Student3 { get; set; }
        public Student Student4 { get; set; }
        public Student Student5 { get; set; }
        public Student Student6 { get; set; }
        public Student Student7 { get; set; }
        public Student Student8 { get; set; }
        public Student Student9 { get; set; }
        public Student Student10 { get; set; }


        public StudentBuilder()
        {
            Student1 = new Student
            {
                FirstName = "Susan",
                LastName = "Tacken",
                StudentID = 1,
                Major = "Music"
            };
            Student2 = new Student
            {
                FirstName = "Hannah",
                LastName = "Longfellow",
                StudentID = 2,
                Major = "Music"
            };
            Student3 = new Student
            {
                FirstName = "Susan",
                LastName = "Tacken",
                StudentID = 3,
                Major = "Music"
            };
            Student4 = new Student
            {
                FirstName = "Mike",
                LastName = "Jackson",
                StudentID = 4,
                Major = "Math"
            };
            Student5 = new Student
            {
                FirstName = "Angie",
                LastName = "Capps",
                StudentID = 5,
                Major = "Physics"
            };
            Student6 = new Student
            {
                FirstName = "Kim",
                LastName = "Manor",
                StudentID = 6,
                Major = "Chemistry"
            };
            Student7 = new Student
            {
                FirstName = "Kate",
                LastName = "Brewer",
                StudentID = 7,
                Major = "Physics"
            };
            Student8 = new Student
            {
                FirstName = "John",
                LastName = "David",
                StudentID = 8,
                Major = "Art"
            };
            Student9 = new Student
            {
                FirstName = "Matt",
                LastName = "Cooper",
                StudentID = 9,
                Major = "Math"
            };
            Student10 = new Student
            {
                FirstName = "Ken",
                LastName = "Brown",
                StudentID = 10,
                Major = "Music"
            };
        }           

        public List<Student> GetAllStudents()
        {
            return new List<Student> { Student1, Student2, Student3, Student4, Student5, Student6, Student7, Student8, Student9, Student10 };
        }
    }
}