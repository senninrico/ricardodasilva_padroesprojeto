using System;
using System.Collections.Generic;

namespace DesignPatterns.ChainResponsability
{
    class GameTable
    {
        private List<Players> InGame;
        private List<Players> OffGame;
        private Players oldplayer;
        private int lastIndex;

        public GameTable()
        {
            lastIndex = 0;
            InGame = new List<Players>();
            OffGame = new List<Players>();
        }

        public void AddPlayer(Players players)
        {
   
            //Set Chain
            if (lastIndex > 0 && InGame.Count < 4)
            {
                lastIndex = InGame.Count;
                oldplayer = InGame[lastIndex - 1];
                players.SetNumber(lastIndex + 1);
                oldplayer.SetSuccessor(players);
                InGame[lastIndex - 1] = oldplayer;
               
            }
            else
            {
                lastIndex++;
                players.SetNumber(lastIndex);
            }


            if (InGame.Count == 3)
            {
                oldplayer = InGame[0];
                players.SetSuccessor(oldplayer);
            }

            if (InGame.Count < 4)
            {

                InGame.Add(players);

            }
            else
            {
                OffGame.Add(players);
            }
        }

        internal void NewRound()
        {

            Console.WriteLine("New Round Started");
            foreach(Players players in InGame)
            {
                players.ResetGame();
            }
        }

        internal void PlayGame(int rounds)
        {
            
            //USE Chain
            for (int i = 0; i < rounds; i++)
            {
             

                InGame[0].PlayRequest();
                foreach (Players itens in OffGame)
                {
                    Console.WriteLine($"Player {itens.GetName()} not in the Game");
                }

                if (i == 3)
                {
                    this.NewRound();
                    rounds = rounds - 4;
                    i = 0;
                }
            }
          
        }
    }



}
