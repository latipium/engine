using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Com.Latipium.Engine.Data {
    public class User {
        [Key]
        public long Id { get; set; }

        public string Name { get; set; }

        public virtual List<Player> Players { get; set; }
    }
}
