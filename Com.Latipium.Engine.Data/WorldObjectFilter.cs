using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Com.Latipium.Engine.Data {
    public class WorldObjectFilter {
        [Key]
        public long Id { get; set; }

        public FilterType Type { get; set; }

        public virtual List<WorldObjectFilterMapping> Mappings { get; set; }
    }
}
