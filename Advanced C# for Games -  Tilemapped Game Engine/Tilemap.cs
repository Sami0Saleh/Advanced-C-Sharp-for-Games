using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C__for_Games____Tilemapped_Game_Engine
{
    public class Tilemap
    {
        private Tile[,] _tiles; 
        private int _widthLimit;
        private int _heightLimit;

        public int Height
        {
            get { return _heightLimit; }
            set { _heightLimit = value; }
        }
        public int Width
        {
            get { return _widthLimit; }
            set { _widthLimit = value; }
        }
        public Tile[,] tiles
        {
            get { return _tiles; }
            set { _tiles = value; }
        }
        // need to create properties for all the private variables
        

        public Tile GetTile(int x, int y)
        {
            if (IsValidPosition(x, y))
            {
                return _tiles[y, x];
            }
            else
            {
                return null; // need to return to user and let him enter new coordinates 
            }
        }

        public void SetTile(int x, int y, Tile tileValue)
        {
            if (IsValidPosition(x, y))
            {
                _tiles[y, x] = tileValue;
            }
            else
            {
                // what if a player tries to set in a unvalided position
            }
        }

        public void PrintTilemap() // need to become a set and put print into a visual class
        {
            for (int row = 0; row < _heightLimit; row++)
            {
                for (int col = 0; col < _widthLimit; col++)
                {
                    if ((row == 0 && (col != 0 && col != (_widthLimit - 1))) || (row == (_heightLimit - 1) && (col != 0 && col != (_widthLimit - 1))))
                    {
                        // ██
                        Console.Write($"{col} "); //Row
                    }
                    else if (col == 0 || col == (_widthLimit - 1)) // Colum
                    {
                        
                        Console.Write($"{row} ");
                    }
                    else if (row != 0 || col != 0)
                    {
                        Console.Write(_tiles[row, col] + $"{col}{row}");
                    }
                }
                Console.WriteLine();
            }

        }
        private bool IsValidPosition(int x, int y)
        {
            return x >= 0 && x < _widthLimit && y >= 0 && y < _heightLimit;
        }
        private void SetNumNLetters()
        {

        }

        public Tilemap(int width, int height)
        {
            _widthLimit = width;
            _heightLimit = height;
            _tiles = new Tile[height, width];
        }

        
    }
}
