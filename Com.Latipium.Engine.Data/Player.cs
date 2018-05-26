using System;
using System.ComponentModel.DataAnnotations;

namespace Com.Latipium.Engine.Data {
    public class Player {
        [Key]
        public long Id { get; set; }

        public long EntityId { get; set; }

        public virtual Entity Entity { get; set; }

        public long UserId { get; set; }

        public virtual User User { get; set; }
    }
}
