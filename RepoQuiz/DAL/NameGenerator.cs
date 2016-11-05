using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Xml.Linq;
using RepoQuiz.Models;

namespace RepoQuiz.DAL
{
    
    public class NameGenerator
    {
        public Student GenerateStudent()
        {
            Random rnd = new Random();
            string[] FirstNames = { "Tom", "Emma", "Kikki", "Jim",
                            "Gino", "Samuel", "Suzy", "Karen",
                            "Sarah", "Anna" };

            string[] LastNames = { "Anderson", "Pence", "Kaine", "Harris",
                                "Pena", "Jones", "Smith", "Cook",
                                "Davidson", "Tucker" };

            string[] Majors = { "Latin", "Math", "Biology", "Pre-Law", "Chemistry", "Visual Art", "Music", "Civil Engineering", "Computer Science", "Nursing", "Pre-Med" };

            string randomFirstName = FirstNames[rnd.Next(FirstNames.Length)];
            string randomLastName = LastNames[rnd.Next(LastNames.Length)];
            string randomMajors = Majors[rnd.Next(Majors.Length)];

            Student newRandom = new Student
            {
                FirstName = randomFirstName,
                LastName = randomLastName,
                Major = randomMajors
            };
            return newRandom;
        }

    }
}
