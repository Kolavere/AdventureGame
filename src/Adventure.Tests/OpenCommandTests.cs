using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;

namespace Adventure.Tests
{

    [TestClass]
    public class OpenCommandTests
    {
        private IConsoleFacade mock;
        private OpenCommand cmd;

        [TestInitialize]
        public void Before_Each_Test()
        {
            mock = MockRepository.GenerateMock<IConsoleFacade>();
            cmd = new OpenCommand(mock);
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
            var result = cmd.IsValid("open box");

            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Execute_Should_Write_To_Console_You_Open_The_Plus_All_But_First_Word_Plus_Ending_Text()
        {
            //Arrange
           
            //Act
            cmd.Execute("open door");
            
            //Assert
            mock.AssertWasCalled(m => m.WriteLine("You open the {0} and peek at what's inside.", "door"));
            
        }
    }
}
