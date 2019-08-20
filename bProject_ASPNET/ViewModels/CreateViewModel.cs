using bProject_ASPNET.Models;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace bProject_ASPNET.ViewModels
{
    public class CreateViewModel
    { 
        [Required(ErrorMessage = "名前を入力してください。"),
            MaxLength(50, ErrorMessage = "50文字以内で名前を入力してください。")]
        public string Name { get; set; }
        [Required(ErrorMessage = "メールアドレスを入力してください。")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
        ErrorMessage = "メールアドレスが正しくありません。")]
        public string Email { get; set; }
        [Required(ErrorMessage = "選択してください。")]
        public Hobby? UserHobby { get; set; }
        public List<IFormFile> Photos {get; set;}
    }
}