using PowerTeam.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PowerTeam.Service.Interface
{
    public interface IDeliveryService
    {
        IQueryable<Delivery> TestMethod();
    }
}
