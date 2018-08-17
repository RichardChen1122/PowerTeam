using System;
using System.Collections.Generic;
using System.Text;
using PowerTeam.Model;
using PowerTeam.DAL.Interface;

namespace PowerTeam.DAL.Reponsitory
{
    public class ItemRepository : BaseRepository<Item>, IItemRepository
    {
        public ItemRepository(PTDBContext ptDBContext) : base(ptDBContext)
        {

        }
    }
}
