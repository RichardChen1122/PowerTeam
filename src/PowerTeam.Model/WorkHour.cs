using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PowerTeam.Model
{
    public class WorkHour : BaseModel
    {
        public DateTime LogDate { get; set; }

        [ForeignKey("User")]
        public Guid UserId { get; set; }

        public User User { get; set; }

        [ForeignKey("Delivery")]
        public Guid DeliveryId { get; set; }

        public Delivery Delivery { get; set; }

        
    }
}
