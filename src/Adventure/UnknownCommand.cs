using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adventure
{
    class UnknownCommand : ICommand
    {

        public bool IsValid(string input)
        {
            return true;
        }

        public void Execute(string input)
        {
            Console.WriteLine("Does not Compute!");
        }

       
    }
}
