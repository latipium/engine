using System;
using System.Net.Sockets;
using Npgsql;
using Com.Latipium.Engine.Data;
using Com.Latipium.Engine.Logging;

namespace Com.Latipium.Engine {
    public static class LatipiumEngine {
        public static void Start(ILatipiumServer server) {
            Context ctx = null;
            try {
                ctx = server.OpenDatabaseContext();
            } catch (SocketException ex) {
                Log.Error(Log.Startup, "Unable to connect to database: {0}", ex.Message);
                Environment.Exit(1);
            } catch (PostgresException ex) {
                Log.Error(Log.Startup, "Unable to authenticate to database: {0}", ex.Message);
                Environment.Exit(1);
            } catch (Exception ex) {
                Log.Error(Log.Startup, "Unknown error while connecting to database: {0}", ex.Message);
                Console.Error.WriteLine(ex);
                Environment.Exit(1);
            }
            ctx.Database.EnsureCreated();
        }
    }
}
