using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X6Z71T.Task;
internal class TaskManager : ITaskManager
{
    private static readonly Lazy<TaskManager> _instance = new(() => new TaskManager());
    public static TaskManager Instance => _instance.Value;
    private List<TaskItem> _tasks = new List<TaskItem>();
    private int _Id = 1;
    private TaskManager() { }
    public void AddTask(TaskItem task)
    {
        _tasks.Add(task with { Id = _Id++ });
    }

    public int CountCompletedTasks()
    {
        return _tasks.Count(t => t.IsCompleted);
    }

    public void DeleteTask(int id)
    {
        _tasks.RemoveAll(t => t.Id == id);
    }

    public IEnumerable<TaskItem> GetCompletedTasks()
    {
        return _tasks.Where(t => t.IsCompleted);
    }

    public IEnumerable<TaskItem> GetTasks()
    {
        return _tasks;
    }
}
