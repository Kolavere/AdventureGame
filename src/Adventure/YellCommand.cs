using System;

namespace Adventure
{
    public class YellCommand : BaseCommand, ICommand
    {
        private IConsoleFacade console;

        public YellCommand(IConsoleFacade console)
        {
            this.console = console;
        }
        
        public bool IsValid(string input)
        {
            return IsFirstWord(input, "yell");
        }

        public void Execute(string input)
        {
            var output = GetAllButFirstWord(input).ToUpper();

            console.ForegroundColor = ConsoleColor.Red;
            console.WriteLine(output);
            console.ResetColor();
        }
    }
}
