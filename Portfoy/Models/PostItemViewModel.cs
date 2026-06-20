using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfoy.Models
{
    public class PostItemViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string CoverImage { get; set; }
        public string AuthorName { get; set; }
        public string[] Tags { get; set; }
        public string CategoryName { get; set; }
    }

    public class PostDetailViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string CoverImage { get; set; }
        public string[] ImageGalery { get; set; }
        public string AuthorName { get; set; }
        public string[] Tags { get; set; }
        public string CategoryName { get; set; }
        public DateTime PublishedDate { get; set; }
    }
}