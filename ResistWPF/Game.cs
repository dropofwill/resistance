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
        private List<Player> playerList = new List<Player>();
        private int[] FIVE_PLAYER_RULES = {2,3,2,3,3}; // Number of players on the mission based on turn
        private GameState aGameState;

        public Game(int n = 5)
        {
            Create(n);
        }

        private void Create(int n)
        {
            numPlayers = n;
            chooseRoles();
            creatPlayers();
            //aGameState = new GameState();
        }

        private void creatPlayers()
        {
            for (var i = 0; i < numPlayers; i++)
            {
                var isSpy = new Boolean();

                if (resistIndex[i] == -1)
                {
                    isSpy = true;
                }
                else
                {
                    isSpy = false;
                }

                var aPlayer = new Player(isSpy);
                playerList.Add(aPlayer);
                Trace.WriteLine(isSpy);
            }
        }

        private Player addPlayer(bool isSpy, string name)
        {
            var aPlayer = new Player(isSpy, name);
            return aPlayer;
        }

        public void chooseRoles()
        {
            resistIndex = populateIndex();
            resistIndex = selectResistIndex();
        }

        private List<int> populateIndex()
        {
            var playersIndex = new List<int>();

            // Make a linked list of the index of players
            for (var i = 0; i < numPlayers; i++)
            {
                playersIndex.Add(i);
            }
            return playersIndex;
        }

        private List<int> selectResistIndex()
        {
            var random = new Random();
            var playersIndex = resistIndex;
            var index = new int();

            while (playersIndex.Count > numPlayers - numSpies)
            {
                index = random.Next(0, playersIndex.Count-1);
                playersIndex[index] = -1;
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

        public GameState AGameState
        {
            get { return aGameState; }
            set { aGameState = value; }
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
