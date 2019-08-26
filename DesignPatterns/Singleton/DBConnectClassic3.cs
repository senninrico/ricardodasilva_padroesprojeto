using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Singleton
{

    public sealed class DBConnectClassic3
    {
        private static int creationCount = 0;
        private static  DBConnectClassic3 _instance = null;
        private static readonly object dblock = new object();


        DBConnectClassic3(){

        }

        public static DBConnectClassic3 Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (dblock)
                    {
                        if (_instance == null)
                        {
                            _instance = new DBConnectClassic3();
                        }
                    }
                }
                return _instance;
            }
        }
    }

}


