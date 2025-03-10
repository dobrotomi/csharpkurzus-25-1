using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

using X6Z71T.Tasks;

namespace X6Z71T.Helper;
internal class FileWriter
{
    public async static Task SerializeToJson(Stream stream, List<TaskItem> task)
    {
        await JsonSerializer.SerializeAsync(stream, task, new JsonSerializerOptions { WriteIndented = true });
    }
}
