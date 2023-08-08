using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyBloggingRazorPage.Models;

namespace MyBloggingRazorPage.Pages
{
    public class ArticleDetailsModel : PageModel
    {
        public ArticleViewModel Article { get; set; }
        private readonly BlogContext _context;

        public ArticleDetailsModel(BlogContext context)
        {
            _context = context;
        }
        public void OnGet(int id)
        {
            Article = _context.Articles.Select(x => new ArticleViewModel
            {
                Id = x.Id,
                Body = x.Body,
                Image = x.Image,
                ImageAlt = x.ImageAlt,
                Title = x.Title
                
            }).FirstOrDefault(x => x.Id == id);
        }
    }
}
