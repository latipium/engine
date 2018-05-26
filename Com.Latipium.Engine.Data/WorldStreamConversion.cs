using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Com.Latipium.Engine.Data {
    public class WorldStreamConversion {
        [Key]
        public long Id { get; set; }

        public virtual List<WorldStreamConversionConsumerMapping> Consumers { get; set; }

        public virtual List<WorldStreamConversionExistenceMapping> Existing { get; set; }

        public virtual List<WorldStreamConversionProducerMapping> Producers { get; set; }
    }
}
