using System;

namespace Adventure
{
    public class DanceCommand : BaseCommand, ICommand
    {
        private IConsoleFacade console;

        public DanceCommand(IConsoleFacade console)
        {
            this.console = console;
        }
        
        public bool IsValid(string input)
        {
            return IsFirstWord(input, "dance");
        }

        public void Execute(string input)
        {
           console.WriteLine("You gracefully dance the {0}.", GetAllButFirstWord(input));
        }
    }
}
