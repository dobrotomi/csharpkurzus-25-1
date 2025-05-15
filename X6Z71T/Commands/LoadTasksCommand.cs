using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using X6Z71T.Helper;
using X6Z71T.Tasks;

namespace X6Z71T.Commands;
internal sealed class LoadTasksCommand : ICommand
{
    public string Name => "load";

    public string Description => "Feladatok betöltése. <load>";

    public async void Run(string[] args)
    {
        string savesFolder = Path.Combine(Directory.GetCurrentDirectory(), "saves");
        Directory.CreateDirectory(savesFolder);

        Console.WriteLine("A mentéseid:");
        ListSaveFiles(savesFolder);

        Console.WriteLine("Melyik mentést szeretnéd betölteni?");
        int index;
        while (true)
        {
            var res = Console.ReadLine();
            if (int.TryParse(res, out int result))
            {
                index = result;
                break;
            }
            else
            {
                Console.WriteLine("Hibás bemenet! Kérlek adj meg egy számot!");
            }
        }



        string[] files = Directory.GetFiles(savesFolder, "*_save.json")
                                  .OrderByDescending(File.GetCreationTime)
                                  .ToArray();

        if (index < 1 || index > files.Length)
        {
            Console.WriteLine("Nem létezik ez a mentés!");
            return;
        }

        string selectedFile = files[index - 1];
        Console.WriteLine($"Mentés betöltése: {selectedFile}");

        await using (FileStream fs = new FileStream(selectedFile, FileMode.Open, FileAccess.Read))
        {
            List<TaskItem>? tasks = FileLoader.DeserializeFromJson(fs);
            var taskManager = TaskManager.GetInstance();
            if(tasks == null)
            {
                Console.WriteLine("Nem találhatóak feladatok!");
                return;
            }
            taskManager.SetTasks(tasks);
            Console.WriteLine("Feladatok betöltve!");

        }
        

    }


    private void ListSaveFiles(string folderPath)
    {
        var files = Directory.GetFiles(folderPath, "*_save.json")
                             .OrderByDescending(File.GetCreationTime)
                             .ToArray();

        if (files.Length == 0)
        {
            Console.WriteLine("Nem találhatóak mentések.");
            return;
        }

        for (int i = 0; i < files.Length; i++)
        {
            string fileName = Path.GetFileName(files[i]);
            Console.WriteLine($"[{i + 1}] - {fileName}");
        }
    }
}
