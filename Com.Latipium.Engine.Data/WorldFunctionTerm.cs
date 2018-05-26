using System;
using System.ComponentModel.DataAnnotations;

namespace Com.Latipium.Engine.Data {
    public class WorldFunctionTerm {
        [Key]
        public long Id { get; set; }

        public long PieceId { get; set; }

        public virtual WorldFunctionPiece Piece { get; set; }

        public DifferentiableFunction Function { get; set; }

        public double Coefficient { get; set; }

        public double Parameter { get; set; }
    }
}
