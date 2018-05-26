using System;
using System.ComponentModel.DataAnnotations;

namespace Com.Latipium.Engine.Data {
    public class Entity {
        [Key]
        public long Id { get; set; }

        public long TileEntityId { get; set; }

        public virtual TileEntity TileEntity { get; set; }

        public long XId { get; set; }

        public virtual WorldFunction X { get; set; }

        public long YId { get; set; }

        public virtual WorldFunction Y { get; set; }

        public long WidthId { get; set; }

        public virtual WorldFunction Width { get; set; }

        public long HeightId { get; set; }

        public virtual WorldFunction Height { get; set; }
    }
}
