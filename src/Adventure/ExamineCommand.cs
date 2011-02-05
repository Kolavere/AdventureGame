using System;

namespace Adventure
{
    public class ExamineCommand : BaseCommand, ICommand
    {
        private IConsoleFacade console;

        public ExamineCommand(IConsoleFacade console)
        {
            this.console = console;
        }
        
        public bool IsValid(string input)
        {
            return IsFirstWord(input, "examine");
        }

        public void Execute(string input)
        {
           console.WriteLine("You examine the {0}.", GetAllButFirstWord(input));
        }
    }
}
