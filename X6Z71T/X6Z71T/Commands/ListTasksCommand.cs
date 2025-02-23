using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X6Z71T.Commands;
internal class ListTasksCommand : ICommand
{
    public string Name => "list";

    public string Description => "Feladatok listázása.";

    public void Run(string[] args)
    {
        throw new NotImplementedException();
    }
}
