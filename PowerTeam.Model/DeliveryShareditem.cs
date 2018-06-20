using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PowerTeam.Model
{
    public class DeliveryShareditem : BaseModel
    {
        [ForeignKey("Delivery")]
        public Guid DeliveryId { get; set; }
        public Delivery Delivery { get; set; }
        [ForeignKey("SharedItem")]
        public Guid SharedItemId { get; set; }
        public SharedItem SharedItem { get; set; }
    }   
}
