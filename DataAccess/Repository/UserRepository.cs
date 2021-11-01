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
        public IEnumerable<User> GetLecturerList() => UserDAO.Instance.GetLecturerList();

        public void AddUser(User user) => UserDAO.Instance.AddUser(user);

        public void UpdateUser(User user) => UserDAO.Instance.UpdateUser(user);

        public void RemoveUser(string userID) => UserDAO.Instance.RemoveUser(userID);
        public IEnumerable<User> GetStudentList() => UserDAO.Instance.GetStudentList();
    }
}
