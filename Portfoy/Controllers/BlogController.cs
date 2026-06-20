using Portfoy.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Portfoy.Controllers
{
    public class BlogController : Controller
    {
        // /blog veya /blog/index
        public ActionResult Index()
        {
            List<PostItemViewModel> posts = new List<PostItemViewModel>();
            for (int i = 1; i < 10; i++)
            {
                posts.Add(new PostItemViewModel
                {
                    Id = i,
                    Title = $"Post Title {i}",
                    Content = $"This is the content of post {i}.",
                    CoverImage = $"https://picsum.photos/800/450?random={i}",
                    AuthorName = $"Author {i % 4 + 1}",
                    Tags = new string[] { "Tag1", "Tag2" },
                    CategoryName = $"Category {i % 3 + 1}"
                });
            }
            return View(posts);
        }

        // /blog/detail/{id}
        public ActionResult Detail(int id)
        {
            // Sahte post detay verisi oluşturuluyor.
            PostDetailViewModel post = new PostDetailViewModel
            {
                Id = id,
                Title = $"Post Title {id}",
                Content = $"This is the content of post {id}.",
                CoverImage = $"https://picsum.photos/800/450?random={id}",
                ImageGalery = new string[]
                {
                    $"https://picsum.photos/800/450?random={id + 1}",
                    $"https://picsum.photos/800/450?random={id + 2}",
                    $"https://picsum.photos/800/450?random={id + 3}"
                },
                AuthorName = $"Author {id % 4 + 1}",
                Tags = new string[] { "Tag1", "Tag2" },
                CategoryName = $"Category {id % 3 + 1}",
                PublishedDate = System.DateTime.Now.AddDays(-id)
            };
            return View(post);
        }

        // /blog/category?category_name={category_name}
        public ActionResult Category(string category_name)
        {
            return View();
        }

        // /blog/tag?tag_name={tag_name}
        public ActionResult Tag(string tag_name)
        {
            return View();
        }
    }
}