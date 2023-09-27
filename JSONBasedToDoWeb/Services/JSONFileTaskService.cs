using JSONBasedToDoWeb.Models;
using System.Text.Json;

namespace JSONBasedToDoWeb.Services
{
    public class JSONFileTaskService
    {
        public JSONFileTaskService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "todo.json"); }
        }

        public IEnumerable<TaskList> GetTasks()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<TaskList[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }
    }
}
