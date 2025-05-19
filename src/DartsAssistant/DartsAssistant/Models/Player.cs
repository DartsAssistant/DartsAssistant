using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartsAssistant.Models
{
    public class Player
    {
        private string _name;
        private int _score;
        private List<int> _throws;
        private double _average;
        private double _first9Average;
        public string Name => _name;
        public int Score => _score;
        public List<int> Throws => _throws;
        public double Average => _average;
        public double First9Average => _first9Average;

        public Player(string name, int score)
        {
            _name = name;
            _score = score;
            _throws = new List<int>();
            _average = 0;
            _first9Average = 0;
        }

        public void Throw(int points)
        {
            _throws.Add(points);
        }

        public void RegisterThrows(int points)
        {
            _score = points;
            CalculateAverage();
        }

        public void CalculateAverage()
        {
            if (_throws.Count > 0)
            {
                // Calculate average for all throws
                _average = _throws.Average();

                // Calculate average for the first 9 throws, or fewer if less than 9
                int count = Math.Min(9, _throws.Count);
                _first9Average = _throws.Take(count).Average();
            }
            else
            {
                _average = 0;
                _first9Average = 0;
            }
        }
    }
}
