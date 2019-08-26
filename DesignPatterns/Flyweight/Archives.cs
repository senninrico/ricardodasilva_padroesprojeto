using System.Collections.Generic;

namespace DesignPatterns.Flyweight
{
    class Archives
    {
        public List<Archive> archives;

        public Archives()
        {
            archives = new List<Archive>
            {
                new Archive("A.doc"),
                new Archive("B.jpg"),
                new Archive("C.ppt")
            };
        }

        public void MoveArchive(string name, string destiny)
        {
            Archive archive = new Archive(name);
            if (archives.Contains(archive))
            {
                archive.MoveTo(destiny);
            }


        }
    }
}
