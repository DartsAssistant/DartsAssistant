using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartsAssistant.Models
{
    class Model
    {
        private GameManager _gameManager;

        public Model(GameManager gameManager)
        {
            _gameManager = gameManager;
        }

        public Player Player
        {
            get { return _gameManager.CurrentPlayer; }
        }

        public List<Player> Players
        {
            get { return _gameManager.Players; }
        }

        public EGameMode GameMode
        {
            get { return _gameManager.GameMode.ModeType; }
        }

        public ESectorType Checkout
        {
            get { return _gameManager.GameMode.Checkout; }
        }

        public void AddPlayer(string name)
        {
            var player = new Player(name, _gameManager.GameMode.StartingScore);
            _gameManager.AddPlayer(player);
        }

        public void StartGame()
        {
            _gameManager.StartGame();
        }
    }
}
