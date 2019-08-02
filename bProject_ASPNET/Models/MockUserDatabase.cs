using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bProject_ASPNET.Models
{
    public class MockUserDatabase : IUserDatabase
    {
        private List<User> _user;
        public MockUserDatabase()
        {
            _user = new List<User>()
            {
                new User() { ID = 1, Name = "Infodex", Email = "infodex@user.com" },
                new User() { ID = 2, Name = "Sujan", Email = "sujan@user.com" },
                new User() { ID = 3, Name = "User", Email = "user@user.com" },
            };

        }

        public IEnumerable<User> GetAllUsers()
        {
            return _user;
        }

        public User GetUser(int id)
        {
            return this._user.FirstOrDefault(e => e.ID == id);
        }
    }
}
