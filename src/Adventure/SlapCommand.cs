using System;

namespace Adventure
{
    public class SlapCommand : BaseCommand, ICommand
    {
        private IConsoleFacade console;

        public SlapCommand(IConsoleFacade console)
        {
            this.console = console;
        }
        
        public bool IsValid(string input)
        {
            return IsFirstWord(input, "slap");
        }

        public void Execute(string input)
        {
           console.WriteLine("You slap {0} upside the head.", GetAllButFirstWord(input));
        }
    }
}
