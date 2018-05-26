using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Com.Latipium.Engine.Data {
    public class Realm {
        [Key]
        public long Id { get; set; }

        public long UniverseId { get; set; }

        public virtual Universe Universe { get; set; }

        public virtual List<WorldStream> Streams { get; set; }
    }
}
