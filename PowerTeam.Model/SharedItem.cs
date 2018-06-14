using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PowerTeam.Model
{
    public class SharedItem: BaseModel
    {
        public SharedItemType ItemType { get; set; }

        public Guid UserGuid { get; set; }

        [ForeignKey("User")]
        public User Owner { get; set; }
        public virtual IList<DeliveryShareditem> DeliverySharedItems { get; set; }
    }

    public enum SharedItemType
    {
        Bug,
        Issue

    }
}
