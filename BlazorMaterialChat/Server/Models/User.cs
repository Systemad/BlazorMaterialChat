using System;
using System.Collections.Generic;

#nullable disable

namespace BlazorMaterialChat.Server.Models
{
    public partial class User
    {
        public long UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
