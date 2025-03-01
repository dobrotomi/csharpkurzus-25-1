using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X6Z71T.Tasks;
internal class TaskManager : ITaskManager
{
    private static readonly Lazy<TaskManager> _instance = new(() => new TaskManager());
    public static TaskManager Instance => _instance.Value;
    private List<TaskItem> _tasks = [];
    private int _id = 1;
    private TaskManager() { }
    public void AddTask(TaskItem task)
    {
        _tasks.Add(task with { Id = _id++ });
    }

    public void SetTasks(List<TaskItem> tasks)
    {
        _tasks = tasks;
    }

    public int CountCompletedTasks()
    {
        return _tasks.Count(t => t.IsCompleted);
    }

    public int DeleteTask(int id)
    {
        return _tasks.RemoveAll(t => t.Id == id);
    }

    public bool CompleteTask(int id)
    {
        var task = _tasks.FirstOrDefault(t => t.Id == id);
        if (task is not null && !task.IsCompleted)
        {
            _tasks.Remove(task);
            _tasks.Add(task with { IsCompleted = true });
            return true;
        }
        return false;
    }

    public IEnumerable<TaskItem> GetCompletedTasks()
    {
        return _tasks.Where(t => t.IsCompleted);
    }

    public IEnumerable<TaskItem> GetTasks()
    {
        return _tasks;
    }

    public TaskItem? GetTask(int id)
    {
        return _tasks.FirstOrDefault(t => t.Id == id);
    }
}
