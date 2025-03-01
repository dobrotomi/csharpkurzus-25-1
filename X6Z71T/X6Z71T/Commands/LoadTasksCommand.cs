using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X6Z71T.Commands;
internal class LoadTasksCommand : ICommand
{
    public string Name => "load";

    public string Description => "Feladatok betöltése.";

    public void Run(string[] args)
    {
        throw new NotImplementedException();
    }
}
