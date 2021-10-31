using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class UserRepository : IUserRepository
    {
        public User GetUserByID(string userId) => UserDAO.Instance.GetUserByID(userId);

        public IEnumerable<User> GetUserList() => UserDAO.Instance.GetUserList();
    }
}
