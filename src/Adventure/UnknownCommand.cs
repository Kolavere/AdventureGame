using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adventure
{
    public class UnknownCommand : ICommand
    {
        private IConsoleFacade console;
        
        public UnknownCommand(IConsoleFacade console)
        {
            this.console = console;
        }
        public bool IsValid(string input)
        {
            return true;
        }

        public void Execute(string input)
        {
            console.WriteLine("Does Not Compute!");
        }

       
    }
}
