using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreateCode_MVC.Models
{
    public class Kullanici
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string UserMail { get; set; }
        public string UserNickName { get; set; }
        public string UserPassword { get; set; }
    }
}
