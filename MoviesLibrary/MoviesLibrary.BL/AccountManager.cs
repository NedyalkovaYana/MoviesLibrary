namespace MoviesLibrary.BL
{
    using MoviesLibrary.Data;
    using MoviesLibrary.BL.Interfaces;
    using MoviesLibrary.Models;
    using MoviesLibrary.ViewModels.Account;

    public class AccountManager : IAccountManager
    {
        private readonly MoviesLibraryDBContext _context;
        public AccountManager()
        {

        }
        public AccountManager(MoviesLibraryDBContext context)
        {
            this._context = context;
        }

        public bool DeleteUser()
        {
            throw new System.NotImplementedException();
        }

        public bool LoginUser()
        {
            throw new System.NotImplementedException();
        }

        public bool RegisterUser(UserAccountViewModel account)
        {
            this._context.UserAccounts.Add(account);
        }
    }
}
