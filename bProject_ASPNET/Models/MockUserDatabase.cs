using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bProject_ASPNET.Models
{
    public class MockUserDatabase
    {
        private List<User> _user;
        public MockUserDatabase()
        {
            _user = new List<User>()
            {
                new User() { ID = 1, Name = "Infodex", Email = "infodex@user.com", UserHobby=0 },
                new User() { ID = 2, Name = "Sujan", Email = "sujan@user.com", UserHobby = 0},
                new User() { ID = 3, Name = "User", Email = "user@user.com", UserHobby= 0 },
            };

        }

        public User Add(User user)
        {
            user.ID = _user.Max(e => e.ID) + 1;
            _user.Add(user);
            return user;
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
