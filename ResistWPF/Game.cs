using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResistWPF
{
    public class Game
    {
        private int numSpies = 2;
       
        private int numPlayers = 5;
        private List<int> resistIndex;
        

        public Game()
        {
            resistIndex = selectResistIndex(numPlayers, numSpies);
        }

        private List<int> selectResistIndex(int numPlayers, int numSpies)
        {
            var random = new Random();
            var playersIndex = new List<int>();
            var index = new int();
            
            // Make a list of the index of players
            for (var i = 0; i < numPlayers; i++)
            {
                playersIndex.Add(i);
            }

            while (playersIndex.Count < numPlayers-numSpies)
            {
                index = random.Next(0,playersIndex.Count);
                playersIndex.RemoveAt(index);
            }

            Debug.WriteLine(playersIndex);
            
            return playersIndex;
        }

        class GameState
        {
            private int turn;
            private int attempts;
            private int wins;
            private int losses;
            private Player leader;
            private List<Player> players;

            public List<Player> Players
            {
                get { return players; }
                set { players = value; }
            }

            /// <summary>
            /// A summary of the game state viewable to all players
            /// </summary>
            /// <param name="players">A list of player objects in turn order with the first leader first</param>
            public GameState(List<Player> ps)
            {
                turn = 1;       // (1..5) keeps track of completed missions
                attempts = 1;   // (1..5) keeps track of the number of attempts to send a team, resets after team approval
                wins = 0;       // Resistance wins, 3 for Resistance victory
                losses = 0;     // Resistance losses, 3 for Spy victory

                players = ps;           // List of players
                leader = players[0];    // First player is the leader
            }
        }

        public int NumPlayers
        {
            get { return numPlayers; }
            set { numPlayers = value; }
        }

        public List<int> ResistIndex
        {
            get { return resistIndex; }
            set { resistIndex = value; }
        }

        public int NumSpies
        {
            get { return numSpies; }
            set { numSpies = value; }
        }
    }
}
