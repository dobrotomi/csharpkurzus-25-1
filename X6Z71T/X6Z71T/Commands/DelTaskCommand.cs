using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X6Z71T.Commands;
internal class DelTaskCommand : ICommand
{
    public string Name => "delete";

    public string Description => "Feladat törlése.";

    public void Run(string[] args)
    {
        throw new NotImplementedException();
    }
}
