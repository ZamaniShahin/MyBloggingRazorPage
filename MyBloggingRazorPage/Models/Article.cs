using System;

namespace MyBloggingRazorPage.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string ImageAlt { get; set; }
        public string ImageTitle { get; set; }
        public string ShortDescription { get; set; }
        public string Body { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreationDate { get; set; }

        public Article(string title, string image
            , string imageAlt, string imageTitle, string shortDescription, string body)
        {
            Title = title;
            Image = image;
            ImageAlt = imageAlt;
            ImageTitle = imageTitle;
            ShortDescription = shortDescription;
            Body = body;
            CreationDate = DateTime.Now;
            IsDeleted = false;
        }
    }
}
