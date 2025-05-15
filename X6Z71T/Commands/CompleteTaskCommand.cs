using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using X6Z71T.Tasks;

namespace X6Z71T.Commands;
internal sealed class CompleteTaskCommand : ICommand
{
    public string Name => "complete";

    public string Description => "Feladat teljesítése. <complete 'id'>";


    public void Run(string[] args)
    {

        if (args.Length < 2)
        {
            Console.WriteLine("Hibás paraméterek! Használd a 'help' parancsot a parancsok listázásához.");
            return;
        }

        var taskManager = TaskManager.GetInstance();

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
            Console.WriteLine("Hibás paraméterek! Használd a 'help' parancsot a parancsok listázásához.");
        }
    }
}
