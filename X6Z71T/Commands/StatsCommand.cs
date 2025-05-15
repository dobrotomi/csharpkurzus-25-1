using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using X6Z71T.Tasks;

namespace X6Z71T.Commands;
internal sealed class StatsCommand : ICommand
{
    public string Name => "statistics";

    public string Description => "Kis statisztika a feladataidról. <statistics>";

    public void Run(string[] args)
    {
        var taskManager = TaskManager.GetInstance();

        var tasks = taskManager.GetTasks().ToList();

        int completed = taskManager.CountCompletedTasks();

        int inProgress = tasks.Count - completed;

        Console.WriteLine($"Összesen {tasks.Count} feladatod van, ebből {completed} kész és {inProgress} folyamatban van.");
    }
}
