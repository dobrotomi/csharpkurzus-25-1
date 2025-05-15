using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using X6Z71T.Helper;
using X6Z71T.Tasks;

namespace X6Z71T.Commands;
internal sealed class SaveTasksCommand : ICommand
{
    public string Name => "save";

    public string Description => "Feladatok mentése. <save>";

    public async void Run(string[] args)
    {
        var taskManager = TaskManager.GetInstance();

        string savesFolder = Path.Combine(Directory.GetCurrentDirectory(), "saves");
        Directory.CreateDirectory(savesFolder);

        string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
        string filePath = Path.Combine(savesFolder, $"{timestamp}_save.json");

        List<TaskItem>? items = taskManager.GetTasks().ToList();
        if (items != null && items.Count != 0)
        {
            await using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                await FileWriter.SerializeToJson(fs, items);
            }
            Console.WriteLine($"Feladatok mentve! {filePath}");

        }
        else
        {
            Console.WriteLine("Nem található feladat!");
        }
        

    }
}
