using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Com.Latipium.Engine.Data {
    public class Universe {
        [Key]
        public long Id { get; set; }

        public string Name { get; set; }

        public DateTime Start { get; set; }

        public virtual List<Realm> Realms { get; set; }
    }
}
