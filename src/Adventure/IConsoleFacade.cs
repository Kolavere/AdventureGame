using System;

namespace Adventure
{
    public interface IConsoleFacade
    {
        void WriteLine(string format, params object[] arg);
        ConsoleColor ForegroundColor { get; set; }
        void ResetColor();
    }
}
