using System;
using System.Collections.Generic;
using System.Text;
using PowerTeam.Model;
using PowerTeam.DAL.Interface;

namespace PowerTeam.DAL.Reponsitory
{
    public class DeliveryShareditemRepository : BaseRepository<DeliveryShareditem>, IDeliveryShareditemRepository
    {
        public DeliveryShareditemRepository(PTDBContext ptDBContext) : base(ptDBContext)
        {

        }
    }
}
