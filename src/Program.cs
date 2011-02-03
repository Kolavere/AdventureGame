using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adventure
{
    class Program
    {
        static void Main(string[] args)
        {
           List<ICommand> commands = new List<ICommand>();
            commands.Add(new EchoCommand());
            commands.Add(new YellCommand());
            commands.Add(new WaveCommand());
            commands.Add(new SlapCommand());
            commands.Add(new SlapCommand());
            commands.Add(new ExamineCommand());
            commands.Add(new OpenCommand());
            commands.Add(new CheerCommand());
            commands.Add(new RudeCommand());

            ICommand defaultCommand = new UnknownCommand();

            do
            {
                var input = Console.ReadLine();
                if (input.Trim() == "exit") break;

               var cmd = commands.FirstOrDefault(list => list.IsValid(input));
                if (cmd == null) cmd = defaultCommand;
                cmd.Execute(input);

            } while (true);
        }
    }
}
