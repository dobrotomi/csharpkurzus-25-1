using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using X6Z71T.Task;

namespace X6Z71T.Commands;
internal class ComplateTaskCommand : ICommand
{
    public string Name => "complate";

    public string Description => "Feladat teljesítése.";


    public void Run(string[] args)
    {
        var taskManager = TaskManager.Instance;

        if (int.TryParse(args[1], out int id))
        {
            bool res = taskManager.CompleteTask(id);
            if(res) {
                Console.WriteLine("Feladat teljesítve!");
            }
            else
            {
                Console.WriteLine("Nem található a megadott azonosítóval feladat, vagy a feladat már teljesítve van!");
            }
        }
        else
        {
            Console.WriteLine("Hibás paraméterek!");
        }
    }
}
