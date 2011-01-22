using System;
using System.Text;

namespace Adventure
{
    public class WaveCommand : BaseCommand, ICommand
    {

       public bool IsValid(string input)
        {
            return IsFirstWord(input, "wave");
        }

        public void Execute(string input)
        {
            Console.WriteLine(String.Format("You wave at {0}.", GetAllButFirstWord(input)));
        }
    }
}
