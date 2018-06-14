using System;
using System.Collections.Generic;
using System.Text;

namespace PowerTeam.Model
{
    public class DeliveryShareditem
    {
        public Guid DeliveryId { get; set; }
        public Delivery Delivery { get; set; }
        public Guid SharedItemId { get; set; }
        public SharedItem SharedItem { get; set; }
    }   
}
