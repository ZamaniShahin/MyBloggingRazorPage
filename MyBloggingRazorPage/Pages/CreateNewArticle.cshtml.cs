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

        public CreateNewArticleModel(BlogContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost(CreateArticle command)
        {
            if (!ModelState.IsValid)
            {
                ErrorMessage = "لطفا اطلاعات خواسته شده را وارد کنید.";
                return Page();
            }
            else
            {
                var article = new Article(command.Title, command.Image, command.ImageAlt, command.ImageTitle,
                    command.ShortDescription, command.Body);
                _context.Articles.Add(article);
                _context.SaveChanges();
                return RedirectToPage("./Index");

            }
        }
    }
}
