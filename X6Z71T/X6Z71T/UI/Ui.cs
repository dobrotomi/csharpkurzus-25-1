using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using X6Z71T.Commands;
using X6Z71T.Helper;

namespace X6Z71T.UI;
internal class Ui
{
    private readonly CommandHelper _commandHelper;
    public Ui(CommandHelper commandHelper) 
    {
        _commandHelper = commandHelper;
    }
    public void Run()
    {
        Console.WriteLine("Feladat Kezelő\nÜdvözöllek a ferladat kezelő programban! Az elérhető parancsok listájához használd a 'help' parancsot.");
        while (true)
        {
            Console.Write(">");
            string? input = Console.ReadLine();
            string[] splittedCmd = input.Split(' ');
            ICommand? command = _commandHelper.Commands.FirstOrDefault(c => c.Name == splittedCmd[0]);

            if (command != null)
            {
                try
                {
                    command.Run(splittedCmd);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Hiba történt a parancs végrehajtása közben: {e.Message}");
                }
            }
            else
            {
                Console.WriteLine("Ismeretlen parancs! Használd a 'help' parancsot a lehetséges parancsok listázásához.");
            }
        }
    }
}
