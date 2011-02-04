using System;

namespace Adventure
{
    public class DanceCommand : BaseCommand, ICommand
    {

        public bool IsValid(string input)
        {
            return IsFirstWord(input, "dance");
        }

        public void Execute(string input)
        {
           Console.WriteLine(String.Format("You gracefully dance the {0}.", GetAllButFirstWord(input)));
        }
    }
}
