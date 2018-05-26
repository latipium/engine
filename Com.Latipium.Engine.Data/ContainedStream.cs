using System;
using System.ComponentModel.DataAnnotations;

namespace Com.Latipium.Engine.Data {
    public class ContainedStream {
        [Key]
        public long Id { get; set; }

        public long TileEntityId { get; set; }

        public virtual TileEntity TileEntity { get; set; }

        public long StreamId { get; set; }

        public virtual WorldStream Stream { get; set; }
    }
}
