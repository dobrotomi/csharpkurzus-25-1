using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X6Z71T.Commands;
internal interface ICommand
{
    public string Name { get; }
    public string Description { get; }
    public void Run(string[] args);
}
