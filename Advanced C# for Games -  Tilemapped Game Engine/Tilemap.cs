using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C__for_Games____Tilemapped_Game_Engine
{
    internal class Tilemap
    {
        private int[,] _tiles;
        private int _width;
        private int _height;

        public Tilemap(int width, int height)
        {
            _width = width;
            _height = height;
            _tiles = new int[height, width]; 
        }

        public int GetTile(int x, int y)
        {
            if (IsValidPosition(x, y))
            {
                return _tiles[y, x];
            }
            else
            {
                
                return -1; 
            }
        }

        public void SetTile(int x, int y, int tileValue)
        {
            if (IsValidPosition(x, y))
            {
                _tiles[y, x] = tileValue;
            }
            else
            {
                
            }
        }

        public void PrintTilemap()
        {
            for (int row = 0; row < _height; row++)
            {
                for (int col = 0; col < _width; col++)
                {
                    if((row == 0 && (col != 0 && col != (_width - 1))) || (row == (_height - 1) && (col != 0 && col != (_width - 1))))
                    {
                        Console.Write("██"); //Row
                    }
                    else if (col == 0 || col == (_width - 1)) // Colum
                    {
                        Console.Write("██");
                    }
                    else if(row != 0 || col != 0)
                    {
                        if (_tiles[row, col] == 0)
                        {
                            Console.Write("  ");
                        }
                        else
                        {
                            Console.Write(_tiles[row, col] + " ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }

        private bool IsValidPosition(int x, int y)
        {
            return x >= 0 && x < _width && y >= 0 && y < _height;
        }
    }

}

