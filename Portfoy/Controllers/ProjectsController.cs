using Portfoy.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Portfoy.Controllers
{
    public class ProjectsController : Controller
    {
        // /Projects veya /Projects/Index
        public ActionResult Index()
        {
            List<ProjectListItemViewModel> projects = new List<ProjectListItemViewModel>();
            for (int i = 1; i < 10; i++)
            {
                projects.Add(new ProjectListItemViewModel
                {
                    Id = i,
                    Title = $"Project {i}",
                    ShortDescription = $"This is a short description for project {i}.",
                    ThumbnailUrl = $"https://picsum.photos/800/450?random={i}",
                    Technologies = new List<string> { "C#", "ASP.NET MVC", "Entity Framework" },
                    Category = "Web Development",
                    IsFeatured = i % 2 == 0,
                    DisplayOrder = i,
                    GitHubUrl = $"#",
                    LiveDemoUrl = $"#"
                });
            }
            return View(projects.OrderBy(x => x.DisplayOrder));
        }

        // /Projects/Detail/{id}
        public ActionResult Detail(int id)
        {
            ProjectDetailViewModel project = new ProjectDetailViewModel
            {
                Id = id,
                Title = $"Project {id}",
                ShortDescription = $"This is a short description for project {id}.",
                DetailedDescription = $"This is a detailed description for project {id}. It includes more information about the project, its features, and technologies used.",
                ThumbnailUrl = $"https://picsum.photos/800/450?random={id}",
                ImageUrls = new List<string>
                {
                    $"https://picsum.photos/800/450?random={id + 10}",
                    $"https://picsum.photos/800/450?random={id + 20}",
                    $"https://picsum.photos/800/450?random={id + 30}"
                },
                Technologies = new List<string> { "C#", "ASP.NET MVC", "Entity Framework" },
                Category = "Web Development",
                GitHubUrl = $"#",
                LiveDemoUrl = $"#",
                StartDate = System.DateTime.Now.AddMonths(-6),
                EndDate = null,
                IsFeatured = id % 2 == 0
            };
            return View(project);
        }
    }
}