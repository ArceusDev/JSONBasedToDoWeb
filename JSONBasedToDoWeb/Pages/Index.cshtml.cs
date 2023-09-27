using JSONBasedToDoWeb.Models;
using JSONBasedToDoWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JSONBasedToDoWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JSONFileTaskService FileTaskService;
        public IEnumerable<TaskList>? Tasks { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, JSONFileTaskService taskService)
        {
            _logger = logger;
            FileTaskService = taskService;
        }

        public void OnGet()
        {
            Tasks = FileTaskService.GetTasks();
        }
    }
}