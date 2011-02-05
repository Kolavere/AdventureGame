using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;

namespace Adventure.Tests
{

    [TestClass]
    public class YellCommandTests
    {
        private IConsoleFacade mock;
        private YellCommand cmd;

        [TestInitialize]
        public void Before_Each_Test()
        {
            mock = MockRepository.GenerateMock<IConsoleFacade>();
            cmd = new YellCommand(mock);
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
            var result = cmd.IsValid("yell Jimmy");

            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Execute_Should_Write_To_Console_All_But_First_Word_In_Caps_And_Red()
        {
            //Arrange
           
            //Act
            cmd.Execute("yell idiot");
            
            //Assert
            mock.AssertWasCalled((m => m.ForegroundColor = ConsoleColor.Red));
                mock.AssertWasCalled(m => m.WriteLine("IDIOT"));
                    mock.AssertWasCalled(m => m.ResetColor());
            
        }
    }
}
