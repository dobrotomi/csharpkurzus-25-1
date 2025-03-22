using X6Z71T.Tasks;

namespace X6Z71T.Commands;
internal sealed class AddTaskCommand : ICommand
{
    public string Name => "add";

    public string Description => "Feladat hozzáadása. <add>";


    public void Run(string[] args)
    {
        var taskManager = TaskManager.Instance;
        string title = "";
        string description = "";
        while (true)
        {
            Console.Write("Cím: ");
            title = Console.ReadLine();

            if (string.IsNullOrEmpty(title))
            {
                Console.WriteLine("A cím nem lehet üres.");
                continue;
            }

            break;
        }

        while (true)
        {
            Console.Write("Leírás: ");
            description = Console.ReadLine();

            if (string.IsNullOrEmpty(description))
            {
                Console.WriteLine("A leírás nem lehet üres.");
                continue;
            }

            break;
        }

        TaskItem task = new()
        {
            Title = title,
            Description = description,
            IsCompleted = false
        };

        taskManager.AddTask(task);

        Console.WriteLine("Feladat hozzáadva.");
    }
}
