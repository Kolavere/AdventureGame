using System;

namespace Adventure
{
    public class CheerCommand : BaseCommand, ICommand
    {

        public bool IsValid(string input)
        {
            return IsFirstWord(input, "cheer");
        }

        public void Execute(string input)
        {
           Console.WriteLine(String.Format("You cheer for {0}.", GetAllButFirstWord(input)));
        }
    }
}
