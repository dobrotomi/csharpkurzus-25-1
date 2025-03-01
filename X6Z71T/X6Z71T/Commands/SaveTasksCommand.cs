using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X6Z71T.Commands;
internal class SaveTasksCommand : ICommand
{
    public string Name => "save";

    public string Description => "Feladatok mentése.";

    public void Run(string[] args)
    {
        throw new NotImplementedException();
    }
}
