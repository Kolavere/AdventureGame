using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;

namespace Adventure.Tests
{

    [TestClass]
    public class WaveCommandTests
    {
        private IConsoleFacade mock;
        private WaveCommand cmd;

        public class MockConsole : IConsoleFacade
        {
            public string WrittenLine { get; set; }

            public void WriteLine(string format, params object[] arg)
            {
                WrittenLine = String.Format(format, arg);
            }
        }

        [TestInitialize]
        public void Before_Each_Test()
        {
            mock = MockRepository.GenerateMock<IConsoleFacade>();
            cmd = new WaveCommand(mock);
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
            var result = cmd.IsValid("wave Jimmy");

            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Execute_Should_Write_To_Console_Wave_Plus_All_But_First_Word()
        {
            //Arrange
           
            //Act
            cmd.Execute("wave to my friends");
            
            //Assert
            mock.AssertWasCalled(m => m.WriteLine("You wave at {0}.", "to my friends"));
            
        }
    }
}
