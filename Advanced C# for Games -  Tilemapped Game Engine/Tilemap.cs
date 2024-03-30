using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C__for_Games____Tilemapped_Game_Engine
{
    public abstract class Tilemap
    {
        private Tile[,] _tiles; // should be built by Tile Class Objects
        private int _width;
        private int _height;
        private List<TileObject> _actors;
        private int _currentTurn;

        // need to create properties for all the private variables

        public int Width => _width;
        public int Height => _height;
      // public List<TileObject> Actors => _actors;
        public int CurrentTurn => _currentTurn;


        public Tilemap(int width, int height)
        {
            _width = width;
            _height = height;
            _tiles = new Tile[height, width];
            InitializeTiles();
            _actors = new List<TileObject>();
            _currentTurn = 0;
        }

        private void InitializeTiles()
        {
            for (int row = 0; row < _height; row++)
            {
                for (int col = 0; col < _width; col++)
                {
                    _tiles[row, col] = new Tile();
                }
            }
        }

        public void SetTileObject(int x, int y, TileObject tileObject)
        {
            if (IsValidPosition(x, y))
            {
                _tiles[y, x].OccupyingObject = tileObject;
                tileObject.MoveToTile(new int[,] { { x, y } }, null);
            }
        }

        public void AddActor(TileObject actor)
        {
            _actors.Add(actor);
            Random rand = new Random();
            int x, y;
            do
            {
                x = rand.Next(Width);
                y = rand.Next(Height);
            } while (_tiles[y, x].OccupyingObject != null);
            SetTileObject(x, y, actor);
        }

        public void HandleTurnOrder()
        {
            _currentTurn = (_currentTurn + 1) % _actors.Count;
            Console.WriteLine($"It's now {_actors[_currentTurn].Name}'s turn.");
        }

        public string GetTile(int x, int y)
        {
            if (IsValidPosition(x, y))
            {
                return _tiles[y, x];
            }
            else
            {
                return "@"; // need to return to user and let him enter new coordinates 
            }
        }

        public void SetTile(int x, int y, string tileValue)
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
            for (int row = 0; row < _height; row++)
            {
                for (int col = 0; col < _width; col++)
                {
                    ChessCheckersMapColor(_tiles[col,row], col, row);
                    if ((row == 0 && (col != 0 && col != (_width - 1))) || (row == (_height - 1) && (col != 0 && col != (_width - 1))))
                    {
                        Console.Write("██"); //Row
                    }
                    else if (col == 0 || col == (_width - 1)) // Colum
                    {
                        Console.Write("██");
                    }
                    else if (row != 0 || col != 0)
                    {
                        Console.Write(_tiles[row, col] + "  ");
                    }
                }
                Console.WriteLine();
            }

        }
        private bool IsValidPosition(int x, int y)
        {
            return x >= 0 && x < _width && y >= 0 && y < _height;
        }




        // should all be moved to a color class
        private void ColorTile(ConsoleColor color, int col, int row)
        {
            Console.BackgroundColor = color;
        }

        private void ChessCheckersMapColor(string tile, int col, int row )
        {
            if ((col + row) % 2 != 0)
            {
            
                ColorTile(ConsoleColor.White, col, row);
            }
            else
            {
                ColorTile(ConsoleColor.Black, col, row);
            }
        }
        public Tilemap(int width, int height)
        {
            _width = width;
            _height = height;
            _tiles = new string[height, width];
        }
    }
}
