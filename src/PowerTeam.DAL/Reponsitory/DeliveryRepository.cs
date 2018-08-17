using System;
using System.Collections.Generic;
using System.Text;
using PowerTeam.DAL.Interface;
using PowerTeam.Model;

namespace PowerTeam.DAL.Reponsitory
{
    public class DeliveryRepository: BaseRepository<Delivery>, IDeliveryRepository
    {
        public DeliveryRepository(PTDBContext ptDBContext) : base(ptDBContext)
        {

        }
    }
}
