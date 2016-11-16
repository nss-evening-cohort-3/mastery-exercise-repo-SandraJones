namespace RepoQuiz.Migrations
{
    using RepoQuiz.Models;
    using DAL;
    using Microsoft.Ajax.Utilities;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RepoQuiz.DAL.StudentContext>
    {
        Student student = new Student();

        //instantiate the NameGenerator
        NameGenerator newStudentGenerator = new NameGenerator();

        //create a list of new students to add to db
        List<Student> newListOfStudents = new List<Student>();

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RepoQuiz.DAL.StudentContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //                         
            var student1 = newStudentGenerator.GenerateStudent();
            newListOfStudents.Add(student1);

            var student2 =  newStudentGenerator.GenerateStudent();
            newListOfStudents.Add(student2);

            var student3 = newStudentGenerator.GenerateStudent();
            newListOfStudents.Add(student3);

            var student4 = newStudentGenerator.GenerateStudent();
            newListOfStudents.Add(student4);

            var student5 = newStudentGenerator.GenerateStudent();
            newListOfStudents.Add(student5);

            var student6 = newStudentGenerator.GenerateStudent();
            newListOfStudents.Add(student6);

            var student7 = newStudentGenerator.GenerateStudent();
            newListOfStudents.Add(student7);

            var student8 = newStudentGenerator.GenerateStudent();
            newListOfStudents.Add(student8);

            var student9 = newStudentGenerator.GenerateStudent();
            newListOfStudents.Add(student9);

            var student10 = newStudentGenerator.GenerateStudent();
            newListOfStudents.Add(student10);
        }
    }
}
