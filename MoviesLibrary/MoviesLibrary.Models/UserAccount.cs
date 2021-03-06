﻿namespace MoviesLibrary.Models
{
    using System.ComponentModel.DataAnnotations;

    public class UserAccount
    {
        public int UserAccountId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }
    }
}
