using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X6Z71T.Task;
internal interface ITaskManager
{
    void AddTask(TaskItem task);
    void DeleteTask(int id);
    IEnumerable<TaskItem> GetTasks();
    IEnumerable<TaskItem> GetCompletedTasks();
    int CountCompletedTasks();
}
