using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X6Z71T.Commands;
internal class StatsCommand : ICommand
{
    public string Name => "statistics";

    public string Description => "Kis statisztika a feladataidról.";

    public void Run(string[] args)
    {
        throw new NotImplementedException();
    }
}
