using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResistWPF
{
    class Turn
    {
        private int numOnMission;
        private GameState myGameState;
        private List<Player> playerList;
        private Player leader;

        public Turn(int nM, ref GameState aGS, ref List<Player> pL)
        {
            numOnMission = nM;
            myGameState = aGS;
            playerList = pL;

            selectionPhase();
            votingPhase();
            missionPhase();

            myGameState.Turn++;
        }

        private void selectionPhase()
        {
            leader = playerList[myGameState.LeaderIndex];

        }
        private void votingPhase()
        {
        }
        private void missionPhase()
        {
        }
    }
}
