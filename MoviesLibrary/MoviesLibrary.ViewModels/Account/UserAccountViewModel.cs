namespace MoviesLibrary.ViewModels.Account
{
    using System.ComponentModel.DataAnnotations;

    public class UserAccountViewModel
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage ="First Name is required!")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required!")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required!")]
        [EmailAddress(ErrorMessage = "Please enter a vaild email.")]﻿
        //[RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Username is required!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Please confirm your password!")]
        public string ConfirmPassword { get; set; }
    }
}
