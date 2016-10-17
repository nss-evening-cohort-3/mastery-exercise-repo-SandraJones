using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepoQuiz.DAL;
using RepoQuiz.Models;
using System.Linq;
using System.Data.Entity;
using Moq;

namespace RepoQuiz.Tests.DAL
{
    [TestClass]
    public class StudentRepositoryTests
    {
        private readonly object entity;

        Mock<StudentContext> mock_context { get; set; }
        Mock<DbSet<Student>> mock_student_table { get; set; }
        List<Student> student_list { get; set; }
        StudentRepository repo { get; set; }

        public void ConnectMockstoData()
        {
            var queryable_list = student_list.AsQueryable();
            // Lie to LINQ make it think that our new Queryable List is a Database table.
            mock_student_table.As<IQueryable<Student>>().Setup(m => m.Provider).Returns(queryable_list.Provider);
            mock_student_table.As<IQueryable<Student>>().Setup(m => m.Expression).Returns(queryable_list.Expression);
            mock_student_table.As<IQueryable<Student>>().Setup(m => m.ElementType).Returns(queryable_list.ElementType);
            mock_student_table.As<IQueryable<Student>>().Setup(m => m.GetEnumerator()).Returns(() => queryable_list.GetEnumerator());

            // Student property return our Queryable List AKA Fake database table.
            mock_context.Setup(c => c.Students).Returns(mock_student_table.Object);

            mock_student_table.Setup(t => t.Add(It.IsAny<Student>())).Callback((Student a) => student_list.Add(a));
            mock_student_table.Setup(t => t.Remove(It.IsAny<Student>())).Callback((Student a) => student_list.Remove(a));
        }

        [TestInitialize]
        public void Initialize()
        {
            // Create Mock StudentContext
            mock_context = new Mock<StudentContext>();
            mock_student_table = new Mock<DbSet<Student>>();
            student_list = new List<Student>(); // Fake
            repo = new StudentRepository(mock_context.Object);
            ConnectMockstoData();
        }

        [TestCleanup]
        public void TearDown()
        {
            repo = null; // 
        }

        [TestMethod]
        public void RepoEnsureCanCreateInstance()
        {
            StudentRepository repo = new StudentRepository();
            Assert.IsNotNull(repo);
        }

        [TestMethod]
        public void RepoEnsureRepoHasContext()
        {
            StudentRepository repo = new StudentRepository();

            StudentContext actual_context = repo.Context;

            Assert.IsInstanceOfType(actual_context, typeof(StudentContext));
        }

        [TestMethod]
        public void RepoEnsureWeHaveNoStudents()
        {
            // Arrange

            // Act
            List<Student> actual_students = repo.GetStudents();
            int expected_students_count = 0;
            int actual_students_count = actual_students.Count;

            // Assert
            Assert.AreEqual(expected_students_count, actual_students_count);
        }

        [TestMethod]
        public void RepoEnsureAddStudentToDatabase()
        {
            // Arrange
            Student my_student = new Student { FirstName = "Jean", LastName = "Franks", StudentID = 2, Major = "Latin"  }; // Property Initializer
           
            // Act
            repo.AddStudent(my_student);
            int actual_student_count = repo.GetStudents().Count;
            int expected_student_count = 1;

            // Assert
            Assert.AreEqual(expected_student_count, actual_student_count);
        }

        [TestMethod]
        public void RepoEnsureFindStudentByStudentID()
        {
            // Arrange
            student_list.Add(new Student { StudentID = 2, FirstName = "Jean", LastName = "Franks", Major = "Latin" });
            student_list.Add(new Student { StudentID = 3, FirstName = "John", LastName = "Smith", Major = "Art" });
            student_list.Add(new Student { StudentID = 4, FirstName = "Carrie", LastName = "Ann", Major = "Music" });

            // Act
            int studentID = 3;
            Student actual_student = repo.FindStudentByStudentID(studentID);

            // Assert
            int expected_student_id = 3;
            int actual_student_id = actual_student.StudentID;
            Assert.AreEqual(expected_student_id, actual_student_id);
        }
        [TestMethod]
        public void RepoEnsureICanRemoveStudentByMajor()
        {
            // Arrange
            student_list.Add(new Student { StudentID = 2, FirstName = "Jean", LastName = "Franks", Major = "Latin" });
            student_list.Add(new Student { StudentID = 3, FirstName = "John", LastName = "Smith", Major = "Art" });
            student_list.Add(new Student { StudentID = 4, FirstName = "Carrie", LastName = "Ann", Major = "Music" });

            // Act
            string major = "Latin";
            Student removed_student =  repo.RemoveStudent(major); 
            int expected_student_count = 2;
            int actual_student_count = repo.GetStudents().Count;
            
            // Assert
            Assert.AreEqual(expected_student_count, actual_student_count);
        }
    }
}
