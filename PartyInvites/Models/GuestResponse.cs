using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "名前を入力してください。")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Emailアドレスを入力してください。")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "正しいEmailアドレスを入力してください。")]
        public string Email { get; set; }

        [Required(ErrorMessage = "電話番号を入力してください。")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "出欠を決めてください。")]
        public bool? WillAttend { get; set; }
    }
}