using System;
using System.Collections.Generic;
using System.Text;

namespace PowerTeam.Model
{
    public class DeliveryTag
    {
        public Guid DeliveryId { get; set; }
        public Delivery Delivery { get; set; }
        public Guid TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
