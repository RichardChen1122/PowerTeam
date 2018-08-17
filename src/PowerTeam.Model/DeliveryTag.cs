using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PowerTeam.Model
{
    public class DeliveryTag : BaseModel
    {
        [ForeignKey("Delivery")]
        public Guid DeliveryId { get; set; }
        public Delivery Delivery { get; set; }
        [ForeignKey("Tag")]
        public Guid TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
