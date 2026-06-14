using System;
using System.Collections.Generic;

namespace Portfoy.Models
{
    public class ProjectListItemViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string ThumbnailUrl { get; set; }
        public List<string> Technologies { get; set; }
        public string Category { get; set; }
        public bool IsFeatured { get; set; }
        public int DisplayOrder { get; set; }
        public string GitHubUrl { get; set; }
        public string LiveDemoUrl { get; set; }
    }

    // Proje detay sayfası için - tüm bilgiler
    public class ProjectDetailViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string DetailedDescription { get; set; }
        public string ThumbnailUrl { get; set; }
        public List<string> ImageUrls { get; set; }
        public List<string> Technologies { get; set; }
        public string Category { get; set; }
        public string GitHubUrl { get; set; }
        public string LiveDemoUrl { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsFeatured { get; set; }
    }
}