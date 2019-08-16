using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bProject_ASPNET.Models
{
    public interface IUserDatabase
    {
        User GetUser(int id);
        IEnumerable<User> GetAllUsers();

        User Add(User user);
        User Update (User userChanges);
        User Delete(int id);
    }
}
