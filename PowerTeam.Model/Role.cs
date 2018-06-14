using System;
using System.Collections.Generic;
using System.Text;

namespace PowerTeam.Model
{
    public class Role : BaseModel
    {
        public RoleType RoleType { get; set; }

        public  IList<UserRole> UserRoles { get; set; }
    }

    public enum RoleType
    {
        Admin,
        Manager,
        Normal
    }
}
