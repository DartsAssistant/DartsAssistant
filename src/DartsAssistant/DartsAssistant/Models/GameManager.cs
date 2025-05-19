using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartsAssistant.Models
{
    public class GameManager
    {
        private List<Player> _players;
        private GameMode _gameMode;
        private Player _currentPlayer;

        public List<Player> Players => _players;
        public GameMode GameMode => _gameMode;
        public Player CurrentPlayer => _currentPlayer;
        public GameManager(List<Player> players, GameMode gameMode)
        {
            _players = players;
            _gameMode = gameMode;
        }

        public GameManager(GameMode gameMode)
        {
            _players = new List<Player>();
            _gameMode = gameMode;
        }

        public void AddPlayer(Player player)
        {
            _players.Add(player);
        }

        
        /// <summary>
        /// Starts the game by initializing the players and the game mode.
        /// </summary>
        public void StartGame()
        {
            foreach (var player in _players)
            {
                player.RegisterThrows(_gameMode.StartingScore);
            }
        }


        public void StartGame(GameMode gameMode, ESectorType checkout)
        {
            _gameMode = gameMode;
            _gameMode.Checkout = checkout;
            StartGame();
        }

        public void NextThrow(int points)
        {
            if (_currentPlayer != null)
            {
                _currentPlayer.Throw(points);
                _currentPlayer.CurrentThrows.Add(points);
                // Check if the player has won
                if (_gameMode.IsWinningConditionMet(_currentPlayer.Score, _currentPlayer.CurrentThrows))
                {
                    EndGame();
                }

                if (_currentPlayer.CurrentThrows.Count == 3)
                {

                    NextPlayer();
                }
            }
        }

        public void NextPlayer()
        {
            _gameMode.RegisterThrows(_currentPlayer);
            int currentIndex = _players.IndexOf(_currentPlayer);
            if (currentIndex < _players.Count - 1)
            {
                _currentPlayer = _players[currentIndex + 1];
            }
            else
            {
                _currentPlayer = _players[0];
            }
            _currentPlayer.CurrentThrows.Clear();
        }

        /// <summary>
        /// Ends the game and determines the winner.
        /// </summary>
        public Player EndGame()
        {
            return _currentPlayer;
        }
    }
}
