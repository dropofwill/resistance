using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResistWPF.Controllers
{
    public class GameController
    {
        private Views.GameView myGameView;
        private Views.CreatePlayerView myCreatePlayerView;
        private Game myGame;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mGV">The current GameView, this</param>
        /// <param name="mG">The current Game</param>
        public GameController(Views.GameView mGV, Game mG)
        {
            myGameView = mGV;
            myGame = mG;

            init();
        }

        private void init()
        {
            myGame.chooseRoles();

            createPlayers();
        }

        private void createPlayers()
        {
            myCreatePlayerView = new Views.CreatePlayerView(this);
            myGameView.GameArea.Content = myCreatePlayerView;
        }
    }
}
