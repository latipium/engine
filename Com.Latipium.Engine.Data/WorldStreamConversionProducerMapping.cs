using System;
using System.ComponentModel.DataAnnotations;

namespace Com.Latipium.Engine.Data {
    public class WorldStreamConversionProducerMapping {
        [Key]
        public long Id { get; set; }

        public double Rate { get; set; }

        public long WorldStreamConversionId { get; set; }

        public virtual WorldStreamConversion WorldStreamConversion { get; set; }

        public long StreamId { get; set; }

        public virtual WorldStream Stream { get; set; }
    }
}
