using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResistWPF
{
    public class Player
    {
        private bool isSpy;
        private string playerName;

        public Player(bool spy)
        {
            isSpy = spy;
        }

        public Player(bool spy, string n)
        {
            isSpy = spy;
            playerName = n;
        }

        public string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }
        public bool IsSpy
        {
            get { return isSpy; }
        }
    }
}
