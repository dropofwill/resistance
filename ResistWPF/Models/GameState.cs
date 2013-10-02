using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResistWPF
{
    public class GameState
    {
        private int turn;
        private int attempts;
        private int wins;
        private int losses;
        //private Player leader;
        private int leaderIndex;

        public List<Player> players;

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
            // leader = players[0];    // First player is the leader
            leaderIndex = 0;
        }

        public int Turn
        {
            get { return turn; }
            set { turn = value; }
        }
        public int Attempts
        {
            get { return attempts; }
            set { attempts = value; }
        }
        public int Wins
        {
            get { return wins; }
            set { wins = value; }
        }
        public int Losses
        {
            get { return losses; }
            set { losses = value; }
        }
        public int LeaderIndex
        {
            get { return leaderIndex; }
            set { leaderIndex = value; }
        }
    }
}
