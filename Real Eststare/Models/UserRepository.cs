using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEststate.Models
{
    public class UserRepository : IUserRepoitory
    {
        List<User> users = new List<User>();

        UserRepository(List<User> u)
        {
            users = u;
        }

        public IEnumerable<User> getUsers()
        {
            return users;
        }

        public User GetUserById(int id)
        {
            foreach (var user in users)
            {
                if (user.id == id)
                {
                    return user;
                }
            }
            return null;
        }

        public void InsertUser(User user)
        {
            users.Add(user);
        }

        public void DeleteUser(int userId)
        {
            User user = GetUserById(userId);
            users.Remove(user);
        }

    }
}
