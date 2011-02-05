using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;

namespace Adventure.Tests
{

    [TestClass]
    public class UnknownCommandTests
    {
        private IConsoleFacade mock;
        private UnknownCommand cmd;

        [TestInitialize]
        public void Before_Each_Test()
        {
            mock = MockRepository.GenerateMock<IConsoleFacade>();
            cmd = new UnknownCommand(mock);
        }

        [TestMethod]
        public void IsValid_Should_Return_True_For_Any_String()
        {
            //Arrange
            
            //Act
            var result = cmd.IsValid("Stupid stuff goes here");

            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Execute_Should_Write_To_Console_Does_Not_Compute()
        {
            //Arrange
           
            //Act
            cmd.Execute("Stupid stuff goes here");
            
            //Assert
            mock.AssertWasCalled(m => m.WriteLine("Does Not Compute!"));
            
        }
    }
}
