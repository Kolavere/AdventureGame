using System;

namespace Adventure
{
    public class OpenCommand : BaseCommand, ICommand
    {
        
        private IConsoleFacade console;

        public OpenCommand(IConsoleFacade console)
        {
            this.console = console;
        }
        
        public bool IsValid(string input)
        {
            return IsFirstWord(input, "open");
        }

        public void Execute(string input)
        {
           console.WriteLine("You open the {0} and peek at what's inside.", GetAllButFirstWord(input));
        }
    }
}
