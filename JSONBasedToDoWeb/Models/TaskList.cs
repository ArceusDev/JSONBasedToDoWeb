using System.Text.Json.Serialization;
using System.Text.Json;

namespace JSONBasedToDoWeb.Models
{
    public class TaskList
    {
            public string? ID { get; set; }
            public string? Title { get; set; }
            public string? Description { get; set; }
            public string? Status { get; set; }
            public string? Date { get; set; }

            public override string ToString() => JsonSerializer.Serialize<TaskList>(this);
    }
}
