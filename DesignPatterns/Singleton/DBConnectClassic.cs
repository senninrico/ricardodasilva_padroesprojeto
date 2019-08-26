namespace DesignPatterns.Singleton
{
    public class DBConnectClassic
    {
        private static int creationCount = 0;

        private static readonly DBConnectClassic _dbSigletonConnection = new DBConnectClassic();

        private DBConnectClassic()
        {
            creationCount++;
        }

        public static DBConnectClassic GetInstance() => _dbSigletonConnection;

        public int GetCreationCount() => creationCount;
    }

}


