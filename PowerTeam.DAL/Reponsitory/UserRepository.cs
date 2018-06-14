using System;
using System.Collections.Generic;
using System.Text;
using PowerTeam.Model;
using PowerTeam.DAL.Interface;

namespace PowerTeam.DAL.Reponsitory
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(PTDBContext ptDBContext) : base(ptDBContext)
        {

        }
    }
}
