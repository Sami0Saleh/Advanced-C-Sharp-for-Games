using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C__for_Games____Tilemapped_Game_Engine
{
    internal class Tilemap
    {
        private int[,] tiles;
        private int width;
        private int height;

        public Tilemap(int width, int height)
        {
            this.width = width;
            this.height = height;
            tiles = new int[height, width]; 
        }

        public int GetTile(int x, int y)
        {
            if (IsValidPosition(x, y))
            {
                return tiles[y, x];
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
                tiles[y, x] = tileValue;
            }
            else
            {
                
            }
        }

        public void PrintTilemap()
        {
            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    Console.Write(tiles[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private bool IsValidPosition(int x, int y)
        {
            return x >= 0 && x < width && y >= 0 && y < height;
        }
    }

}
}
