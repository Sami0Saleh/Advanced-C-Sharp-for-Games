using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C__for_Games____Tilemapped_Game_Engine
{
    internal class Tile
    {
        private int _tileValue;

        
        public int TileValue
        {
            get { return _tileValue; }
            set { _tileValue = value; }
        }

        
        public Tile(int initialValue)
        {
            _tileValue = initialValue;
        }

        // Method to check if the tile is occupied
        public bool IsOccupied()
        {
            return _tileValue != 0;
        }

        // Method to occupy the tile with a tile object
        public bool OccupyTile()
        {
            if (!IsOccupied())
            {
                _tileValue = 1; // Arbitrarily assigning 1 to represent an occupied tile
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
            _tileValue = 0; // Resetting the tile value to represent an unoccupied tile
        }
    }
}
