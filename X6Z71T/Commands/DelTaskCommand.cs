using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using X6Z71T.Tasks;

namespace X6Z71T.Commands;
internal sealed class DelTaskCommand : ICommand
{
    public string Name => "delete";

    public string Description => "Feladat törlése. <delete 'id'>";


    public void Run(string[] args)
    {
        if(args.Length < 2)
        {
            Console.WriteLine("Hibás paraméterek! Használd a 'help' parancsot a parancsok listázásához.");
            return;
        }

        var taskManager = TaskManager.GetInstance();

        if (int.TryParse(args[1], out int id))
        {
            int res = taskManager.DeleteTask(id);
            if (res > 0)
            {
                Console.WriteLine("Feladat törölve!");
            }
            else
            {
                Console.WriteLine("Nem található a megadott azonosítóval feladat!");
            }
        }
        else
        {
            Console.WriteLine("Hibás paraméterek! Használd a 'help' parancsot a parancsok listázásához.");
        }
    }
}
