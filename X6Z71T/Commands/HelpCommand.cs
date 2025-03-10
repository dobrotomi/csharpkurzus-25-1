using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using X6Z71T.Helper;

namespace X6Z71T.Commands;
internal class HelpCommand : ICommand
{
    public string Name => "help";

    public string Description => "Parancsok listázása.";


    public void Run(string[] args)
    {
        CommandHelper commandHelper = new();
        List<ICommand> commandInstances = commandHelper.Commands;

        foreach (ICommand commandInstance in commandInstances)
        {
            Console.WriteLine($" - [{commandInstance.Name}] -> {commandInstance.Description}");
        }
    }
}
