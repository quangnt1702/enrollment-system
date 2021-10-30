using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Models
{
    public partial class StatusUser
    {
        public StatusUser()
        {
            Users = new HashSet<User>();
        }

        public int StatusId { get; set; }
        public string StatusName { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
