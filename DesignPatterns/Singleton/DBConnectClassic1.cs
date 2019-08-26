namespace DesignPatterns.Singleton
{
    public class DBConnectClassic1
    {
        private static int creationCount = 0;
        private static readonly DBConnectClassic1 _instance = new DBConnectClassic1();
        private DBConnectClassic1()
        {
            creationCount++;

        }
        public int GetCreationCount() => creationCount;
        public static DBConnectClassic1 Instance = _instance;
    }

}


