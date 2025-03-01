using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X6Z71T.Tasks;
internal interface ITaskManager
{
    void AddTask(TaskItem task);
    int DeleteTask(int id);
    bool CompleteTask(int id);
    TaskItem GetTask(int id);
    IEnumerable<TaskItem> GetTasks();
    IEnumerable<TaskItem> GetCompletedTasks();
    int CountCompletedTasks();
}
