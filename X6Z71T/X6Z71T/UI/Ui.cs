using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace X6Z71T.UI;
internal class Ui
{
    public void Run()
    {
        Console.WriteLine("Feladat Kezelő\nÜdvözöllek a ferladat kezelő programban! Az elérhető parancsok listájához használd a 'help' parancsot.");
        while (true)
        {
            Console.Write(">");
            string? input = Console.ReadLine();
            string[] splittedCmd = input.Split(' ');
            ICommand? command = null;

            if (command != null)
            {

            }
            else
            {
                Console.WriteLine("Ismeretlen parancs! Használd a 'help' parancsot a lehetséges parancsok listázásához.");
            }
        }
    }
}
