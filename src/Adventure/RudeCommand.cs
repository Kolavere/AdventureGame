using System;

namespace Adventure
{
    public class RudeCommand : BaseCommand, ICommand
    {
        private IConsoleFacade console;
        
        public RudeCommand(IConsoleFacade console)
        {
            this.console = console;
        }
        public bool IsValid(string input)
        {
            return IsFirstWord(input, "rude");
        }

        public void Execute(string input)
        {
           console.WriteLine("You make a rude comment to {0}.", GetAllButFirstWord(input));
        }
    }
}
