using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MyBloggingRazorPage.Models;

namespace MyBloggingRazorPage.Pages
{
    public class IndexModel : PageModel
    {
        public List<ArticleViewModel> Articles { get; set; }
        private readonly BlogContext _context;

        public IndexModel(BlogContext context)
        {
            _context = context;
        }

        public IActionResult OnGetDeleted(int id)
        {
            var article = _context.Articles.First(x => x.Id == id);
            article.IsDeleted = true;
            _context.SaveChanges();
            return RedirectToPage("./Index");
        }
        public void OnGet()
        {
            Articles = _context.Articles.Where(x => x.IsDeleted == false)
                .Select(x => new ArticleViewModel
                {
                    Id = x.Id,
                    Body = x.Body,
                    ShortDescription = x.ShortDescription,
                    Image = x.Image,
                    ImageAlt = x.ImageAlt,
                    ImageTitle = x.ImageTitle,
                    CreationDate = x.CreationDate.ToString(),
                    Title = x.Title
                }).ToList();
        }
    }
}
