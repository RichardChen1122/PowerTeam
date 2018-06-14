using System;
using System.Collections.Generic;
using System.Text;

namespace PowerTeam.Model
{
    public class User:BaseModel
    {
        public string Alias { get; set; }

        public virtual IList<UserRole> UserRoles { get; set; }
    }
}
