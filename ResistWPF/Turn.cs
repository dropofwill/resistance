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

        public Turn(int nM, ref GameState aGS)
        {
            numOnMission = nM;
            myGameState = aGS;

            myGameState.Turn++;
        }
    }
}
