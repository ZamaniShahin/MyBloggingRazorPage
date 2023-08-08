using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyBloggingRazorPage.Models
{
    public class CreateArticle
    {
        [DisplayName("عنوان")]
        [Required(ErrorMessage = "لطفا عنوان را وارد کنید.")]
        [MinLength(15,ErrorMessage = "عنوان شما باید حداقل 15 حرف داشته باشد")]
        [MaxLength(255,ErrorMessage = "عنوان شما نمیتواند بیشتر از 255 حرف داشته باشد.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "لطفا عکس را وارد کنید.")]
        [DisplayName("مسیر عکس")]
        public string Image { get; set; }
        [Required(ErrorMessage = "لطفا Alt عکس را وارد کنید.")]
        [DisplayName("Alt عکس")]
        public string ImageAlt { get; set; }
        [Required(ErrorMessage = "لطفا عنوان عکس را وارد کنید.")]
        [DisplayName("عنوان عکس")]
        public string ImageTitle { get; set; }
        [Required(ErrorMessage = "لطفا توضیحات کوتاه مقاله را وارد کنید.")]
        [DisplayName("توضیحات کوتاه")]
        public string ShortDescription { get; set; }
        [Required(ErrorMessage = "لطفا متن مقاله را وارد کنید.")]
        [DisplayName("متن مقاله")]
        public string Body { get; set; }
    }
}
