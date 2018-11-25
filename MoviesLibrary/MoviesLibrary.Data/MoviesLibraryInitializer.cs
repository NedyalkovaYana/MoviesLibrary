using System.Collections.Generic;
using MoviesLibrary.Models;

namespace MoviesLibrary.Data
{
    using System.Linq;

    public class MoviesLibraryInitializer //: CreateDatabaseIfNotExists<MoviesLibraryDbContext context>
    {
        public static void Seed(IMoviesLibraryDBContext context)
        {
            var users = new List<User>
            {
                new User()
                {
                    FirstName = "Ivan",
                    LastName = "Ivanov",
                    Email = "test@test.bg",
                    Password = "test"
                },
                new User()
                {
                    FirstName = "Admin",
                    LastName = "Admin",
                    Email = "admin@admin.bg",
                    Password = "admin"
                }
            };

            context.Users.AddRange(users);
        }
    }
}
