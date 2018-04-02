using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEststate.Models
{
    interface IUserRepoitory
    {
        IEnumerable<User> getUsers();
        User GetUserById(int UserId);
        void InsertUser(User User);
        void DeleteUser(int UserID);
    }
}
