using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyBloggingRazorPage.Models;

namespace MyBloggingRazorPage.Pages
{
    public class CreateNewArticleModel : PageModel
    {
        private readonly BlogContext _context;

        public CreateNewArticleModel(BlogContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
        }

        public void OnPost(CreateArticle command)
        {
            var article = new Article(command.Title, command.Image, command.ImageAlt, command.ImageTitle,
                command.ShortDescription,command.Body);
            _context.Articles.Add(article);
            _context.SaveChanges();
            ViewData["Success"] = "عملیات با موفقیت انجام شد.";
        }
    }
}
