using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UserLogin.Models
{
    public partial class User
    {
        
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
