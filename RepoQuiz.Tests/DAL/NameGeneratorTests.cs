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
    }
}
