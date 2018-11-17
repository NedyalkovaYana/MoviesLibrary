namespace MoviesLibrary.BL.Interfaces
{
    using MoviesLibrary.Models;
    using MoviesLibrary.ViewModels.Account;

    public interface IAccountManager
    {
       bool RegisterUser(UserAccountViewModel account);

        bool LoginUser();
        bool DeleteUser();
    }
}
