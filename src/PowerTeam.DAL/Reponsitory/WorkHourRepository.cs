using System;
using System.Collections.Generic;
using System.Text;
using PowerTeam.Model;
using PowerTeam.DAL.Interface;

namespace PowerTeam.DAL.Reponsitory
{
    public class WorkHourRepository : BaseRepository<WorkHour>, IWorkHourRepository
    {
        public WorkHourRepository(PTDBContext ptDBContext) : base(ptDBContext)
        {

        }
    }
}
