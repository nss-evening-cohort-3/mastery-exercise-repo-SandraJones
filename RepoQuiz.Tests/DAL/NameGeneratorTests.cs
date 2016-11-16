using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepoQuiz.DAL;

namespace RepoQuiz.Tests.DAL
{
    [TestClass]
    public class NameGeneratorTests
    {
        [TestMethod]
        public void ensureICanInstantiateNameGenerator()
        {
            //ARRANGE
            NameGenerator namegen = new NameGenerator();
            
            //ASSERT
            Assert.IsNotNull(namegen);

        }
        [TestMethod]
        public void ensurenamegenReturnsaRandomStudent()
        {
            //ARRANGE
            NameGenerator namegen = new NameGenerator();

            //ACT
            var newRandom = namegen.GenerateStudent();//will always return a type student


            //ASSERT
            Assert.IsNotNull(newRandom);
        }
        //make sure it returns all properties returning all things as not null
        //then a test to be sure returned objects are not redundant
        [TestMethod]
        public void EnsureNameGeneratorReturnsPropertyStudentID()
        {
            //ARRANGE
            NameGenerator namegen = new NameGenerator();

            ////ACT
            var newRandom = namegen.GenerateStudent().StudentID;//will always return a type student


            ////ASSERT
            Assert.IsNotNull(newRandom);
        }
        [TestMethod]
        public void EnsureNameGeneratorReturnsPropertyFirstName()
        {
            //ARRANGE
            NameGenerator namegen = new NameGenerator();

            ////ACT
            var newRandom = namegen.GenerateStudent().FirstName;//will always return a type student


            ////ASSERT
            Assert.IsNotNull(newRandom);
        }
        [TestMethod]
        public void EnsureNameGeneratorReturnsPropertyLastName()
        {
            //ARRANGE
            NameGenerator namegen = new NameGenerator();

            ////ACT
            var newRandom = namegen.GenerateStudent().LastName;//will always return a type student


            ////ASSERT
            Assert.IsNotNull(newRandom);
        }
        [TestMethod]
        public void EnsureNameGeneratorReturnsPropertyMajor()
        {
            //ARRANGE
            NameGenerator namegen = new NameGenerator();

            ////ACT
            var newRandom = namegen.GenerateStudent().Major;//will always return a type student


            ////ASSERT
            Assert.IsNotNull(newRandom);
        }

    }
}
