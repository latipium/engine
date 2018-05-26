using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Com.Latipium.Engine.Data {
    public class Tile {
        [Key]
        public long Id { get; set; }

        public long TileEntityId { get; set; }

        public virtual TileEntity TileEntity { get; set; }

        public double X { get; set; }

        public double Y { get; set; }

        public double Width { get; set; }

        public double Height { get; set; }
    }
}
