using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepoQuiz.Models;

namespace RepoQuiz.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void EnsureICanInstantiateStudent()
        {
            //Arrange
            //Act
            Student _student = new Student();
            

            //Assert
            Assert.IsNotNull(_student);

        }
    }
}
