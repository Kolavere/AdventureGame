using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;

namespace Adventure.Tests
{

    [TestClass]
    public class RudeCommandTests
    {
        private IConsoleFacade mock;
        private RudeCommand cmd;

        [TestInitialize]
        public void Before_Each_Test()
        {
            mock = MockRepository.GenerateMock<IConsoleFacade>();
            cmd = new RudeCommand(mock);
        }

        [TestMethod]
        public void IsValid_Should_Return_False_For_Invalid_String()
        {
            //Arrange
            
            //Act
            var result = cmd.IsValid("Stupid stuff goes here");

            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void IsValid_Should_Return_True_For_Valid_String()
        {
            //Arrange
            
            //Act
            var result = cmd.IsValid("rude Jimmy");

            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Execute_Should_Write_To_Console_You_Make_A_Rude_Comment_To_Plus_All_But_First_Word()
        {
            //Arrange
           
            //Act
            cmd.Execute("rude the folks around");
            
            //Assert
            mock.AssertWasCalled(m => m.WriteLine("You make a rude comment to {0}.", "the folks around"));
            
        }
    }
}
