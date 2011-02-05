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
           commands.Add(new EchoCommand(new ConsoleFacade()));
            commands.Add(new YellCommand(new ConsoleFacade()));
            commands.Add(new WaveCommand(new ConsoleFacade()));
            commands.Add(new SlapCommand(new ConsoleFacade()));
            commands.Add(new DanceCommand(new ConsoleFacade()));
            commands.Add(new ExamineCommand(new ConsoleFacade()));
            commands.Add(new OpenCommand(new ConsoleFacade()));
            commands.Add(new CheerCommand(new ConsoleFacade()));
            commands.Add(new RudeCommand(new ConsoleFacade()));

            ICommand defaultCommand = new UnknownCommand(new ConsoleFacade());

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
