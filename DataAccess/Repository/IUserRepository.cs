using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUserList();
        User GetUserByID(string userId);
        IEnumerable<User> GetLecturerList();
        void AddUser(User user);
        void UpdateUser(User user);
        void RemoveUser(string userID);
    }
}
