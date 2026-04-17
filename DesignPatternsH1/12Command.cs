using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsH1;

public interface Command
{
    void Execute();
}

public class SaveCommand : Command
{
    public void Execute() => Console.WriteLine("Save Command");
}

public class LoadCommand : Command
{
    public void Execute() => Console.WriteLine("Load Command");
}

public class MyMenuItem
{
    Command command;
    public MyMenuItem(Command command)
    {
        this.command = command;
    }
    public void Click()
    {
        command.Execute();
    }
}