using System;
using System.ComponentModel.DataAnnotations;

namespace Com.Latipium.Engine.Data {
    public class WorldObjectFilterMapping {
        [Key]
        public long Id { get; set; }

        public long ObjectId { get; set; }

        public virtual WorldObject Object { get; set; }

        public long FilterId { get; set; }

        public virtual WorldObjectFilter Filter { get; set; }
    }
}
