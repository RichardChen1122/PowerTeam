using System;
using System.Collections.Generic;
using System.Text;

namespace PowerTeam.Model
{
    public class Tag : BaseModel
    {
        public string Name { get; set; }

        public virtual IList<DeliveryTag> DeliveryTags { get; set; }

    }
}
