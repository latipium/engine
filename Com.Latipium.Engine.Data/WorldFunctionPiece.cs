using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Com.Latipium.Engine.Data {
    public class WorldFunctionPiece {
        [Key]
        public long Id { get; set; }

        public long FunctionId { get; set; }

        public virtual WorldFunction Function { get; set; }

        public virtual List<WorldFunctionTerm> Terms { get; set; }
    }
}
