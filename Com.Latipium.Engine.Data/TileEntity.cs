using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Com.Latipium.Engine.Data {
    public class TileEntity {
        [Key]
        public long Id { get; set; }

        public long StreamId { get; set; }

        public virtual WorldStream Stream { get; set; }

        public long FilterId { get; set; }

        public virtual WorldObjectFilter Filter { get; set; }

        public long ZId { get; set; }

        public WorldFunction Z { get; set; }

        public long DepthId { get; set; }

        public WorldFunction Depth { get; set; }

        public virtual List<ContainedStream> Inventory { get; set; }
    }
}
