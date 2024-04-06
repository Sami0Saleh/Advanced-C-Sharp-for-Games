using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace Advanced_C__for_Games____Tilemapped_Game_Engine
{
    public abstract class Tilemap : IEnumerable<Tile>
    {
        
        public Tile[,] _tiles;
        private int _mapWidth;
        private int _mapHeight;

        // need to create properties for all the private variables

        public int Width => _mapWidth;
        public int Height => _mapHeight;


        public Tilemap(int width, int height)
        {
            _mapWidth = width;
            _mapHeight = height;
            _tiles = new Tile[height, width];
            InitializeTiles();
        }

        private void InitializeTiles()
        {
            for (int row = 0; row < _mapHeight; row++)
            {
                for (int col = 0; col < _mapWidth; col++)
                {
                //    _tiles[row, col] = new Tile();
                }
            }
        }

        public void SetTileObject(int x, int y, TileObject tileObject)
        {
            if (IsValidPosition(x, y))
            {
              //  _tiles[y, x].OccupyingObject = tileObject;
                tileObject.MoveToTile(new int[,] { { x, y } }, null);
            }
        }

        public void AddActor(TileObject actor)
        {
            // _actors.Add(actor);
            Random rand = new Random();
            int x, y;
           /* do
            {
                x = rand.Next(Width);
                y = rand.Next(Height);
            }
            while (_tiles[y, x].OccupyingObject != null);
            SetTileObject(x, y, actor);*/
        }

       /* public void HandleTurnOrder()
        {
            _currentTurn = (_currentTurn + 1) % _actors.Count;
            Console.WriteLine($"It's now {_actors[_currentTurn].Name}'s turn.");
        }*/

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
            for (int row = 0; row < _mapHeight; row++)
            {
                for (int col = 0; col < _mapWidth; col++)
                {
                    ChessCheckersMapColor(_tiles[col,row], col, row);
                    if ((row == 0 && (col != 0 && col != (_mapWidth - 1))) || (row == (_mapHeight - 1) && (col != 0 && col != (_mapWidth - 1))))
                    {
                        Console.Write("██"); //Row
                    }
                    else if (col == 0 || col == (_mapWidth - 1)) // Colum
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
            return x >= 0 && x < _mapWidth && y >= 0 && y < _mapHeight;
        }




        // should all be moved to a color class
        private void ColorTile(ConsoleColor color, int col, int row)
        {
            Console.BackgroundColor = color;
        }

        private void ChessCheckersMapColor(Tile tile, int col, int row)
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


        /// IEnumerble and IEnumrator
        ///  
        ///  
        /// 

        public IEnumerator<Tile> GetEnumerator()
        {
            return null;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        /// 
        ///  2D Position Interface 
        /// 
        public struct IPosition
        {
            // needs to override Must override ToString(), GetHashCode(), and Equals()
         
            public override string ToString()
            {
                return base.ToString();
            }
            public override int GetHashCode()
            { 
               return base.GetHashCode();
            }
            public override bool Equals([NotNullWhen(true)] object? obj)
            {
                return base.Equals(obj);
            }

            // Must override operators for addition and subtraction(+, -)



        }
    }
}
