using System;

namespace Adventure
{
    public class CheerCommand : BaseCommand, ICommand
    {
        private IConsoleFacade console;

        public CheerCommand(IConsoleFacade console)
        {
            this.console = console;
        }
        
        public bool IsValid(string input)
        {
            return IsFirstWord(input, "cheer");
        }

        public void Execute(string input)
        {
           console.WriteLine("You cheer for {0}.", GetAllButFirstWord(input));
        }
    }
}
