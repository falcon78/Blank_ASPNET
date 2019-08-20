using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace bProject_ASPNET.Models
{
    public class User
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="名前を入力してください。"),
            MaxLength(50,ErrorMessage ="50文字以内で名前を入力してください。")]
        public string Name { get; set; }
        [Required(ErrorMessage ="メールアドレスを入力してください。")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
        ErrorMessage = "メールアドレスが正しくありません。")]
        public string Email { get; set; }
        [Required(ErrorMessage ="選択してください。")]
        public Hobby? UserHobby { get; set; }

        public string PhotoPath {get; set;} 
    }
}
