using System;

namespace Adventure
{
    public class SlapCommand : BaseCommand, ICommand
    {

        public bool IsValid(string input)
        {
            return IsFirstWord(input, "slap");
        }

        public void Execute(string input)
        {
           Console.WriteLine(String.Format("You slap {0} upside the head.", GetAllButFirstWord(input)));
        }
    }
}
