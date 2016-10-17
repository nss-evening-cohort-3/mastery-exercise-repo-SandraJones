namespace RepoQuiz.Migrations
{
    using DAL;
    using Microsoft.Ajax.Utilities;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RepoQuiz.DAL.StudentContext>
    {
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
            context.Students.AddOrUpdate(
            //Students
            new Student
            {
                FirstName = "Susan",
                LastName = "Tacken",
                StudentID = 1,
                Major = "Music"
            },

            new Student
            {
                FirstName = "Hannah",
                LastName = "Longfellow",
                StudentID = 2,
                Major = "Music"
            },
            new Student
            {
                FirstName = "Susan",
                LastName = "Tacken",
                StudentID = 3,
                Major = "Music"
            },
            new Student
            {
                FirstName = "Mike",
                LastName = "Jackson",
                StudentID = 4,
                Major = "Math"
            },
            new Student
            {
                FirstName = "Angie",
                LastName = "Capps",
                StudentID = 5,
                Major = "Physics"
            },
            new Student
            {
                FirstName = "Kim",
                LastName = "Manor",
                StudentID = 6,
                Major = "Chemistry"
            },
            new Student
            {
                FirstName = "Kate",
                LastName = "Brewer",
                StudentID = 7,
                Major = "Physics"
            },
            new Student
            {
                FirstName = "John",
                LastName = "David",
                StudentID = 8,
                Major = "Art"
            },
            new Student
            {
                FirstName = "Matt",
                LastName = "Cooper",
                StudentID = 9,
                Major = "Math"
            },
            new Student
            {
                FirstName = "Ken",
                LastName = "Brown",
                StudentID = 10,
                Major = "Music"
            }
        );

        }
    }
}
