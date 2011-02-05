using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;

namespace Adventure.Tests
{

    [TestClass]
    public class CheerCommandTests
    {
        private IConsoleFacade mock;
        private CheerCommand cmd;

        [TestInitialize]
        public void Before_Each_Test()
        {
            mock = MockRepository.GenerateMock<IConsoleFacade>();
            cmd = new CheerCommand(mock);
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
            var result = cmd.IsValid("cheer Jimmy");

            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Execute_Should_Write_To_Console_Cheer_Plus_All_But_First_Word()
        {
            //Arrange
           
            //Act
            cmd.Execute("cheer everybody around");
            
            //Assert
            mock.AssertWasCalled(m => m.WriteLine("You cheer for {0}.", "everybody around"));
            
        }
    }
}
