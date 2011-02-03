using System;

namespace Adventure
{
    public class ExamineCommand : BaseCommand, ICommand
    {

        public bool IsValid(string input)
        {
            return IsFirstWord(input, "examine");
        }

        public void Execute(string input)
        {
           Console.WriteLine(String.Format("You examine the {0}.", GetAllButFirstWord(input)));
        }
    }
}
