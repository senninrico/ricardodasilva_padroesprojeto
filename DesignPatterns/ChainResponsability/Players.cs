using System;

namespace DesignPatterns.ChainResponsability
{
    class Players : Player

    {
        private string PlayerName;
        public Players(string name)
        {
            PlayerName = name;
            
        }

        private bool Played;
            public void SetNumber(int number)
        {
            base.PlayerNumber = number;
        }
        public override void PlayRequest()
        {
          //use Chain
                
            if (successor != null  && Played)
            {
                successor.PlayRequest();
            }else
            {
                if (!Played)
                {
                    Played = true;
                    Console.WriteLine($"P{base.PlayerNumber}: {PlayerName} play!");
                }
                else
                {
                
                Console.WriteLine("Not in the game");

                }
                   
            }

        }

        internal void ResetGame()
        {
            Played = false;
        }

        internal string GetName()
        {
            return PlayerName;
        }
    }



}
