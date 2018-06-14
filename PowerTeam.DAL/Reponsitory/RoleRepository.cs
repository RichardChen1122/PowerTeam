using System;
using System.Collections.Generic;
using System.Text;
using PowerTeam.Model;
using PowerTeam.DAL.Interface;

namespace PowerTeam.DAL.Reponsitory
{
    public class RoleRepository : BaseRepository<Role>, IRoleRepository
    {
        public RoleRepository(PTDBContext ptDBContext) : base(ptDBContext)
        {

        }
    }
}
