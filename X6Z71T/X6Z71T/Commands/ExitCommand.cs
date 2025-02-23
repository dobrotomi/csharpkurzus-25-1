using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X6Z71T.Commands;
internal class ExitCommand : ICommand
{
    public string Name => "exit";

    public string Description => "Program bezárása.";

    public void Run(string[] args)
    {
        Console.WriteLine("Viszlát!");
        Environment.Exit(0);
    }
}
