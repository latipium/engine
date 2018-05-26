using System;
using Com.Latipium.Engine.Data;

namespace Com.Latipium.Engine {
    public interface ILatipiumServer {
        Context OpenDatabaseContext();
    }
}
