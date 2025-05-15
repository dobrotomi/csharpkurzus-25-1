using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using X6Z71T.Tasks;

namespace X6Z71T.Commands;
internal sealed class ListTasksCommand : ICommand
{
    public string Name => "list";

    public string Description => "Feladatok listázása. <list>";


    public void Run(string[] args)
    {
        var taskManager = TaskManager.GetInstance();

        var tasks = taskManager.GetTasks().ToList();

        foreach (var task in tasks) {
            Console.WriteLine($"[{task.Id}] Feladat: \nCím: {task.Title}\nLeírás: {task.Description}\n{(task.IsCompleted ? "Kész" : "Folyamatban")}\n");
        }
    }
}
