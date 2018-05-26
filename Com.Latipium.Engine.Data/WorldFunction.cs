using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Com.Latipium.Engine.Data {
    public class WorldFunction {
        [Key]
        public long Id { get; set; }

        public virtual List<WorldFunctionPiece> Pieces { get; set; }
    }
}
