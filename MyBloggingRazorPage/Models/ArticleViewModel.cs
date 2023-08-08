using System;

namespace MyBloggingRazorPage.Models
{
    public class ArticleViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string ImageAlt { get; set; }
        public string ImageTitle { get; set; }
        public string ShortDescription { get; set; }
        public string Body { get; set; }
        public string CreationDate { get; set; }
    }
}
