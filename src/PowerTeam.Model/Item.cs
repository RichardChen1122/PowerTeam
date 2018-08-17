using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PowerTeam.Model
{
    public class Item : BaseModel
    {
        public ItemType ItemType { get; set; }

        public Guid UserGuid { get; set; }

        [ForeignKey("User")]
        public User Owner { get; set; }

        public virtual Delivery Delivery { get; set; }

        public virtual IList<Tag> Tags  { get; set; }
    }

    public enum ItemType
    {
        WorkItem,
        Issue,
        TestPlan,
        Conclusion,
        AutomationTest,
        ManualTest
    }
}
