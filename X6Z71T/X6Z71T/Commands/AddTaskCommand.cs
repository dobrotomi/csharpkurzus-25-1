using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X6Z71T.Commands;
internal class AddTaskCommand : ICommand
{
    public string Name => "add";

    public string Description => "Feladat hozzáadása.";

    public void Run(string[] args)
    {
        throw new NotImplementedException();
    }
}
