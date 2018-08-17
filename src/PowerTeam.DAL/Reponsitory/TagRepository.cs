using System;
using System.Collections.Generic;
using System.Text;
using PowerTeam.Model;
using PowerTeam.DAL.Interface;

namespace PowerTeam.DAL.Reponsitory
{
    public class TagRepository : BaseRepository<Tag>, ITagRepository
    {
        public TagRepository(PTDBContext ptDBContext) : base(ptDBContext)
        {

        }
    }
}
