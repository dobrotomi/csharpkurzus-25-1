using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using X6Z71T.Commands;

namespace X6Z71T.Helper;
internal class CommandHelper
{
    public List<ICommand> Commands { get; }

    public CommandHelper()
    {
        Assembly assembly = Assembly.GetExecutingAssembly();
        var commandTypes = assembly.GetTypes()
            .Where(t => typeof(ICommand).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract);

        Commands = commandTypes.Select(t => (ICommand)Activator.CreateInstance(t)).ToList();
    }
}
