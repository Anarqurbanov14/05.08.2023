﻿using Microsoft.AspNetCore.Identity;

namespace WinePage.Models
{
    public class AppUser:IdentityUser
    {
        public string FullName { get; set; }
        public bool IsAdmin { get; set; }

        //public List<BasketItem> BasketItems { get; set; }
    }
}
