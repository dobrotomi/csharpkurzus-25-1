using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

using X6Z71T.Tasks;

namespace X6Z71T.Helper;
internal class FileLoader
{
    public static List<TaskItem>? DeserializeFromJson(Stream stream)
    {
        return JsonSerializer.Deserialize<List<TaskItem>>(stream);
    }
}
