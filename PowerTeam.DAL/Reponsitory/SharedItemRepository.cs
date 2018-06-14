using System;
using System.Collections.Generic;
using System.Text;
using PowerTeam.Model;
using PowerTeam.DAL.Interface;

namespace PowerTeam.DAL.Reponsitory
{
    public class SharedItemRepository : BaseRepository<SharedItem>, ISharedItemRepository
    {
        public SharedItemRepository(PTDBContext ptDBContext) : base(ptDBContext)
        {

        }
    }
}
