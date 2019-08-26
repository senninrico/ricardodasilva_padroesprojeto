namespace DesignPatterns.ChainResponsability
{
    abstract class Player
    {
        protected int PlayerNumber;
        protected Player successor;

        public void SetSuccessor(Player successor)
        {
            this.successor = successor;
        }

        public abstract void PlayRequest();
    }



}
