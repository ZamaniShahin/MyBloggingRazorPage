namespace MyBloggingRazorPage.Models
{
    public class CreateArticle
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public string ImageAlt { get; set; }
        public string ImageTitle { get; set; }
        public string ShortDescription { get; set; }
        public string Body { get; set; }
    }
}
