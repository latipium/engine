using System;
using System.ComponentModel.DataAnnotations;

namespace Com.Latipium.Engine.Data {
    public class WorldObject {
        [Key]
        public long Id { get; set; }

        public string ClassName { get; set; }
    }
}
