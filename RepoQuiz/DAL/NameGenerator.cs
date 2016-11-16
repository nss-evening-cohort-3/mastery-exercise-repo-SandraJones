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
        Random rnd = new Random();
        public Student GenerateStudent()
        {       
                string[] FirstNames = { "Tom", "Emma", "Kikki", "Jim",
                            "Gino", "Samuel", "Suzy", "Karen",
                            "Sarah", "Anna" };
                int indexFirstNames = rnd.Next(0, FirstNames.Length);

                string[] LastNames = { "Anderson", "Pence", "Kaine", "Harris",
                                "Pena", "Jones", "Smith", "Cook",
                                "Davidson", "Tucker" };
                int indexLastNames = rnd.Next(0, LastNames.Length);

                string[] Majors = { "Latin", "Math", "Biology", "Pre-Law", "Chemistry", "Visual Art", "Music", "Civil Engineering", "Computer Science", "Nursing", "Pre-Med" };
                int indexMajors = rnd.Next(0, Majors.Length);

                string randomFirstName = FirstNames[rnd.Next(FirstNames.Length)];
                string randomLastName = LastNames[rnd.Next(LastNames.Length)];
                string randomMajors = Majors[rnd.Next(Majors.Length)];

                string FirstName = randomFirstName;
                string LastName = randomLastName;
                string Major = randomMajors;

               
            Student newRandom = new Student()
            {
                FirstName = randomFirstName,
                LastName = randomLastName,
                Major = randomMajors
            };

            return newRandom;
           
        }
    }
}
