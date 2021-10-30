using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Models
{
    public partial class TblStatusUser
    {
        public TblStatusUser()
        {
            TblUsers = new HashSet<TblUser>();
        }

        public string StatusId { get; set; }
        public string StatusName { get; set; }

        public virtual ICollection<TblUser> TblUsers { get; set; }
    }
}
