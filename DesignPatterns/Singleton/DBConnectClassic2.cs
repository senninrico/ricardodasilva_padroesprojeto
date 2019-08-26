using System;

namespace DesignPatterns.Singleton
{
    public class DBConnectClassic2
    {
        private static int creationCount = 0;

        private static readonly Lazy<DBConnectClassic2> _conn = new Lazy<DBConnectClassic2>(() => new DBConnectClassic2());
        private DBConnectClassic2()
        {
            creationCount++;
        }
        public static DBConnectClassic2 Instance2 => _conn.Value;
        public int GetCreationCount() => creationCount;
    }

}


