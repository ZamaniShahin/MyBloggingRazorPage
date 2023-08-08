using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyBloggingRazorPage.Models;

namespace MyBloggingRazorPage.Pages
{
    public class CreateNewArticleModel : PageModel
    {
        private readonly BlogContext _context;
        public CreateArticle Command { get; set; }
        [TempData]
        public string ErrorMessage { get; set; }
        [TempData]
        public string SuccessMessage { get; set; }

        public CreateNewArticleModel(BlogContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
        }

        public void OnPost(CreateArticle command)
        {
            if (ModelState.IsValid)
            {
                var article = new Article(command.Title, command.Image, command.ImageAlt, command.ImageTitle,
                    command.ShortDescription, command.Body);
                _context.Articles.Add(article);
                _context.SaveChanges();
                SuccessMessage = "عملیات با موفقیت انجام شد.";
            }
            else
            {
                ErrorMessage = "لطفا اطلاعات خواسته شده را وارد کنید.";
            }
        }
    }
}
