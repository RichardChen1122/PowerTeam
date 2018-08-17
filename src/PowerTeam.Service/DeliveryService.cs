using PowerTeam.Model;
using PowerTeam.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PowerTeam.Service
{
    public class DeliveryService : BaseService, IDeliveryService
    {
        public DeliveryService(IDataContext dataContext) : base(dataContext)
        {
        }

        public IQueryable<Delivery> TestMethod()
        {
            return PTDataContext.Delivery.GetAll();
        }
    }
}
