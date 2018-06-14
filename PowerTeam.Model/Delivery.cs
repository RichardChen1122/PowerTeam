using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PowerTeam.Model
{
    public class Delivery : BaseModel
    {

        public DeliveryType DeliveryType { get; set; }

        public Delivery ParentDelivery { get; set; }
        public string Title { get; set; }

        public virtual IList<Item> Items { get; set; }
        public virtual IList<DeliveryShareditem> DeliveryShareditems { get; set; }
        public virtual IList<DeliveryTag> DeliveryTags { get; set; }
        public virtual IList<Delivery> SubDeliveries { get; set; }
        public DateTime StartDate { get; set; }

        public DateTime? CloseDate { get; set; }
    }

    public enum DeliveryType
    {
        Release,
        MileStone,
        Task,
        Document
    }
}
