using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X6Z71T.Tasks;
public record class TaskItem
{
    public int Id { get; init; }
    public required string Title { get; init; }
    public required string Description { get; init; }
    public required bool IsCompleted { get; init; }
}
    

