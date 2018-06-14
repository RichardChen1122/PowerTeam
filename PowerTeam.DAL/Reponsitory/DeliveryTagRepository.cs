using System;
using System.Collections.Generic;
using System.Text;
using PowerTeam.Model;
using PowerTeam.DAL.Interface;

namespace PowerTeam.DAL.Reponsitory
{
    public class DeliveryTagRepository : BaseRepository<DeliveryTag>, IDeliveryTagRepository
    {
        public DeliveryTagRepository(PTDBContext ptDBContext) : base(ptDBContext)
        {

        }
    }
}
