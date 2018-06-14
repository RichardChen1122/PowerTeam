using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PowerTeam.Model
{
    public class BaseModel
    {
        [Key]
        public Guid Guid { get; set; }
        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }

        public string CreateBy { get; set; }

        public string UpdateBy { get; set; }
    }
}
