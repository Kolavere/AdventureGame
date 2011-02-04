using System;

namespace Adventure
{
    public class ConsoleFacade : IConsoleFacade
    {

        public void WriteLine(string format, params object[] arg)
        {
            Console.WriteLine(format, arg);
        }
    }
}
