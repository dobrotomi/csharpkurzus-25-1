using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X6Z71T.Task;
internal class TaskFactory
{
    public static TaskItem CreateTask(string title, string description)
    {
        return new TaskItem
        {
            Title = title,
            Description = description,
            IsCompleted = false
        };
    }
}
