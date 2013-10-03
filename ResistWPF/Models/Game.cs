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
        private int[] FIVE_PLAYER_RULES = {2,3,2,3,3};         // Number of players on the mission based on turn
        private GameState aGameState;

        public Game(int n = 5)
        {
            Create(n);
        }

        private void Create(int n)
        {
            numPlayers = n;

            //chooseRoles();
            //createPlayers();
            
            //aGameState = new GameState(playerList);
            
            //GameLoop();
        }

        public Player createAPlayer(string name, int resIndex)
        {
            var isSpy = isPlayerSpy(resIndex);

            var player = new Player(isSpy,name);
            playerList.Add(player);

            return player;
        }

        private void createPlayers()
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
            }
        }

        private bool isPlayerSpy(int resIndex)
        {
            var isSpy = new Boolean();

            if (resistIndex[resIndex] == -1)
            {
                isSpy = true;
            }
            else
            {
                isSpy = false;
            }

            return isSpy;
        }

        private Player addPlayer(bool isSpy, string name)
        {
            var aPlayer = new Player(isSpy, name);
            return aPlayer;
        }

        public void chooseRoles()
        {
            //Fill list of ints with the appropriate amount according to number of players
            resistIndex = populateIndex();

            //Randomly choose the appropriate number of players to be spies by setting their number to -1
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

            for (var i = 1; i < numPlayers - numSpies; i++)
            {
                do {
                    index = random.Next(0, playersIndex.Count - 1);
                } while (playersIndex[index] == -1);

                playersIndex[index] = -1;
            }
            return playersIndex;
        }

        private void GameLoop()
        {
            for (var i = 0; i < 5; i++)
            {
                var turn = new Turn(FIVE_PLAYER_RULES[i], ref aGameState, ref playerList);
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
