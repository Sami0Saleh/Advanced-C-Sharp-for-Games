using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C__for_Games____Tilemapped_Game_Engine
{
    internal class Tile
    {
        private string _tileValue;

        
        public string TileValue
        {
            get { return _tileValue; }
            set { _tileValue = value; }
        }

        
        public Tile(string initialValue)
        {
            _tileValue = initialValue;
        }

        // Method to check if the tile is occupied
        public bool IsOccupied()
        {
            return _tileValue != null;
        }

        // Method to occupy the tile with a tile object
        public bool OccupyTile()
        {
            if (!IsOccupied())
            {
                _tileValue = "@"; // Arbitrarily assigning 1 to represent an occupied tile
                return true;
            }
            else
            {
                return false; // Tile is already occupied
            }
        }

        // Method to vacate the tile
        public void VacateTile()
        {
            _tileValue = "  "; // Resetting the tile value to represent an unoccupied tile
        }
    }
}
