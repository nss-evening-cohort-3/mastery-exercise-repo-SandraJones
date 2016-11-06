namespace RepoQuiz.Migrations
{
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


            //instantiate the NameGenerator
            NameGenerator newStudentGenerator = new NameGenerator();

            //create a list of new students to add to db
            List<Student> newListOfStudents = new List<Student>();
                        
            var student1 = newStudentGenerator.GenerateStudent();
            var student2 = newStudentGenerator.GenerateStudent();
            var student3 = newStudentGenerator.GenerateStudent();
            var student4 = newStudentGenerator.GenerateStudent();
            var student5 = newStudentGenerator.GenerateStudent();
            var student6 = newStudentGenerator.GenerateStudent();
            var student7 = newStudentGenerator.GenerateStudent();
            var student8 = newStudentGenerator.GenerateStudent();
            var student9 = newStudentGenerator.GenerateStudent();
            var student10 = newStudentGenerator.GenerateStudent();

            context.Students.AddOrUpdate(x => x.StudentID, student1, student2, student3, student4, student5, student6, student7, student8, student9, student10);











        }
    }
}
