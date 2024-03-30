using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C__for_Games____Tilemapped_Game_Engine
{
    public abstract class Tile
    {
        private TileObject _tileObject = null;
        private string _tileValue = "  ";  // get from tile object obtaining it, if emptey is 2 spaces
        // tile class should know what position hes in
        private string actor;
        public string TileValue
        {
            get { return _tileValue; }
            set { _tileValue = value; }
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
                _tileValue = "  "; // Arbitrarily assigning 1 to represent an occupied tile
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

        public Tile(string initialValue)
        {
            _tileValue = initialValue;
        }
    }
}
