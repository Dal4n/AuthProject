﻿using Microsoft.AspNetCore.Identity;

namespace AuthAPI.Models
{
    public class AppUser : IdentityUser
    {
        public string? FullName { get; set; }
    }
}
