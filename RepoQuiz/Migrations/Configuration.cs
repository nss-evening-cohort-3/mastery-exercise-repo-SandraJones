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

            //moved this outside of the seed method function to test
            //instantiate the NameGenerator
           // NameGenerator newStudentGenerator = new NameGenerator();
            //create a list of new students to add to db
           // List<Student> newListOfStudents = new List<Student>();
            //tried student., newListOfStudents.
            
                        
            var student1 = newStudentGenerator.GenerateStudent();
            newListOfStudents.Add(student1);

            var student2 =  newStudentGenerator.GenerateStudent();
            newListOfStudents.Add(student2);

            //should be able to do this in some type of loop 

            //for (var i = 1; i <= 10; i++)
            //{
            //    var student[i] = newStudentGenerator.GenerateStudent();
            //    newListOfStudents.Add(student[i]);

            //may have to do a foreach similar to:
            //public Dealer()
            //{
            //    rnd = new Random();
            //    // Initialize the deck.
            //    int deckCtr = 0;
            //    foreach (var suit in Enum.GetValues(typeof(Suit)))
            //    {
            //        foreach (var faceValue in Enum.GetValues(typeof(FaceValue)))
            //        {
            //            Card card = new Card();
            //            card.Suit = (Suit)suit;
            //            card.FaceValue = (FaceValue)faceValue;
            //            deck[deckCtr] = card;
            //            deckCtr++;
            //        }
            //    }

                //}

                //var student3 = newStudentGenerator.GenerateStudent();
                //var student4 = newStudentGenerator.GenerateStudent();
                //var student5 = newStudentGenerator.GenerateStudent();
                //var student6 = newStudentGenerator.GenerateStudent();
                //var student7 = newStudentGenerator.GenerateStudent();
                //var student8 = newStudentGenerator.GenerateStudent();
                //var student9 = newStudentGenerator.GenerateStudent();
                //var student10 = newStudentGenerator.GenerateStudent();

                // context.Students.AddOrUpdate(t => t.StudentID, student1, student2);//, student3, student4, student5, student6, student7, student8, student9, student10);


                //Methods(non -static) methods work with instances.
                //A static methods does not have a reference to an 
                //instance(passed implicitly as "this" to all instance methods), 
                //so the syntax of the call uses the name of the type. As a result, 
                //static methods cannot use instance methods(there is no known 
                //instance to pass).Same thing is with the properties (they are 
                //also methods, through accessors.A hint: the syntax for instance 
                //method call is: instanceVariableName.MethodName(methodParameters).


            }
    }
}
