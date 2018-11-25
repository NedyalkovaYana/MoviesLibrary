using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore.Migrations;
using MoviesLibrary.BL.Interfaces;
using MoviesLibrary.Common.Exceptions;
using MoviesLibrary.Models;
using MoviesLibrary.Repository;

namespace MoviesLibrary.BL
{
    public class UserManager : IUserManager
    {
        private IRepository<User> _repository;

        public UserManager(IRepository<User> repository)
        {
            this._repository = repository;
        }

        public User Authenticate(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return null;
            }
                

            var user = _repository.Find(x => x.Username == username).FirstOrDefault();

            if (user == null)
            {
                return null;
            }

           //TODO verify password

            return user;
        }

        public IEnumerable<User> GetAll()
        {
            return this._repository.GetAll();
        }

        public User GetById(int id)
        {
            return this._repository.GetById(id);
        }

        public User Create(User user, string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new AppException("Password is required");
            }

            var usernameExist = this._repository.Find(x => x.Username == user.Username).FirstOrDefault();

            if (usernameExist != null)
            {
                throw new AppException("Username \"" + user.Username + "\" is already taken");
            }
               

            byte[] passwordHash, passwordSalt;
            CreatePasswordHash(password, out passwordHash, out passwordSalt);

            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            this._repository<User>.Add(user);
            this._repository.SaveChanges();

            return user;
        }

        public void Update(User user, string password = null)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
