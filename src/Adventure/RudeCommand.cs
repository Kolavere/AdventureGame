using System;

namespace Adventure
{
    public class RudeCommand : BaseCommand, ICommand
    {

        public bool IsValid(string input)
        {
            return IsFirstWord(input, "rude");
        }

        public void Execute(string input)
        {
           Console.WriteLine(String.Format("You make a rude comment to {0}", GetAllButFirstWord(input)));
        }
    }
}
