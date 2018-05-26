using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Com.Latipium.Engine.Data {
    public class WorldStream {
        [Key]
        public long Id { get; set; }

        public long RealmId { get; set; }

        public virtual Realm Realm { get; set; }

        public long ObjectId { get; set; }

        public virtual WorldObject Object { get; set; }

        public long AmountId { get; set; }

        public virtual WorldFunction Amount { get; set; }

        public long ParentId { get; set; }

        public virtual WorldStream Parent { get; set; }

        public virtual List<WorldStream> Children { get; set; }

        public double AmountConsumedFromParent { get; set; }

        public DateTime TimeBranchedFromParent { get; set; }

        public virtual List<WorldStreamConversionConsumerMapping> ConversionsConsumed { get; set; }

        public virtual List<WorldStreamConversionExistenceMapping> ConversionsExisting { get; set; }

        public virtual List<WorldStreamConversionProducerMapping> ConversionsProduces { get; set; }
    }
}
