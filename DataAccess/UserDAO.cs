using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class UserDAO
    {
        private static UserDAO instance = null;
        private static readonly object instanceLock = new object();
        public static UserDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if(instance == null)
                    {
                        instance = new UserDAO();
                    }
                    return instance;
                }
            }
        }

        public List<TblUser> GetUserList()
        {
            List<TblUser> userList = new List<TblUser>();
            try
            {
                using var context = new EnrollmentSystemContext();
                userList = context.TblUsers.Where(r => r.RoleId.Contains("ST")).ToList();
                //userList = from us in context.TblUsers where us.RoleId == "ST" select us;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return userList;
        }
    }
}
