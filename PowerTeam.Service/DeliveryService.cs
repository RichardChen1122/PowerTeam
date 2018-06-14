using PowerTeam.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace PowerTeam.Service
{
    public class DeliveryService : BaseService, IDeliveryService
    {
        public DeliveryService(IDataContext dataContext) : base(dataContext)
        {
        }

        public void TestMethod()
        {
            PTDataContext.Delivery.GetAll();
        }
    }
}
