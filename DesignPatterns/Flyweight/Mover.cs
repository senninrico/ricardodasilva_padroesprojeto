namespace DesignPatterns.Flyweight
{
    class Mover
    {
        private readonly Archives archives;

        public Mover()
        {
            archives = new Archives();
        }

        public void MoveTo(string file, string destiny)
        {
            archives.MoveArchive(file, destiny);
        }
    }
}
