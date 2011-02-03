using System;

namespace Adventure
{
    public class OpenCommand : BaseCommand, ICommand
    {

        public bool IsValid(string input)
        {
            return IsFirstWord(input, "open");
        }

        public void Execute(string input)
        {
           Console.WriteLine(String.Format("You open the {0} and peek at what's inside.", GetAllButFirstWord(input)));
        }
    }
}
