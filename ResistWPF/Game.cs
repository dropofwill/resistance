using System;
using System.Collections;
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
        private int[] FIVE_PLAYER_RULES = {2,3,2,3,3};
        

        public Game(int n = 5)
        {
            Create(n);
        }

        private void Create(int n)
        {
            numPlayers = n;
            chooseRoles();
        }


        public void chooseRoles()
        {
            resistIndex = populateIndex(numPlayers);
            resistIndex = selectResistIndex(resistIndex);
        }

        private List<int> populateIndex(int numPlayers)
        {
            var playersIndex = new List<int>();

            // Make a list of the index of players
            for (var i = 0; i < numPlayers; i++)
            {
                playersIndex.Add(i);
            }

            return playersIndex;
        }

        private List<int> selectResistIndex(List<int> resistIndex)
        {
            var random = new Random();
            var playersIndex = resistIndex;
            var index = new int();

            while (playersIndex.Count > playersIndex.Count - numSpies)
            {
                index = random.Next(0, playersIndex.Count-1);
                playersIndex.RemoveAt(index);

                Console.WriteLine(index);
            }

            return playersIndex;
        }

        private void GameLoop()
        {
            for (var i = 0; i < 5; i++)
            {
                var turn = new Turn(FIVE_PLAYER_RULES[i]);
            }
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
                turn = 0;       // (0..4) keeps track of completed missions
                attempts = 0;   // (0..4) keeps track of the number of attempts to send a team, resets after team approval
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
