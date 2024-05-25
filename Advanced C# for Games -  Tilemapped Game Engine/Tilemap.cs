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

    public class Tilemap : IEnumerable<Tile>
    {
        private Tile[,] _tiles;
        private int _mapWidth;
        private int _mapHeight;
        private List<Actor> _actors;
        private Dictionary<int, Tile> _tileDictionary;

        public int Width => _mapWidth;
        public int Height => _mapHeight;

        public Tilemap(int width, int height)
        {
            _mapWidth = width;
            _mapHeight = height;
            _tiles = new Tile[height, width];
            _actors = new List<Actor>();
            _tileDictionary = new Dictionary<int, Tile>();
            InitializeTiles();
        }

        private void InitializeTiles()
        {
            int idCounter = 0;
            for (int row = 0; row < _mapHeight; row++)
            {
                for (int col = 0; col < _mapWidth; col++)
                {
                    var tile = new SimpleTile(idCounter++, row, col, "  ");
                    _tiles[row, col] = tile;
                    _tileDictionary.Add(tile.ID, tile);
                }
            }
        }

        public void SetTileObject(int x, int y, TileObject tileObject)
        {
            if (IsValidPosition(x, y))
            {
                var tile = (SimpleTile)_tiles[y, x];
                tile.OccupyingObject = tileObject;
                tileObject.MoveToTile(new int[,] { { x, y } }, tile.Position);
            }
        }

        public Tile GetTile(int x, int y)
        {
            return IsValidPosition(x, y) ? _tiles[y, x] : null;
        }

        public Tile GetTileByID(int id)
        {
            return _tileDictionary.TryGetValue(id, out var tile) ? tile : null;
        }

        public void SetTile(int x, int y, Tile tileValue)
        {
            if (IsValidPosition(x, y))
            {
                _tiles[y, x] = tileValue;
                _tileDictionary[tileValue.ID] = tileValue;
            }
        }

        public void MoveActor(Actor actor, int newX, int newY)
        {
            if (IsValidPosition(newX, newY))
            {
                var currentTile = GetTile(actor.Position[0, 0], actor.Position[0, 1]);
                var newTile = GetTile(newX, newY);
                if (newTile.IsOccupied())
                {
                    Console.WriteLine("Tile is already occupied.");
                    return;
                }

                currentTile.VacateTile();
                newTile.OccupyTile();
                actor.Position = new int[,] { { newX, newY } };
            }
            else
            {
                Console.WriteLine("Invalid position.");
            }
        }

        public void AddActor(Actor actor, int x, int y)
        {
            if (IsValidPosition(x, y) && !_tiles[y, x].IsOccupied())
            {
                _actors.Add(actor);
                actor.Position = new int[,] { { x, y } };
                _tiles[y, x].OccupyTile();
            }
            else
            {
                Console.WriteLine("Invalid position or tile is occupied.");
            }
        }

        public void RemoveActor(Actor actor)
        {
            var tile = GetTile(actor.Position[0, 0], actor.Position[0, 1]);
            if (tile != null && _actors.Contains(actor))
            {
                tile.VacateTile();
                _actors.Remove(actor);
            }
        }

        public void PrintTilemap()
        {
            for (int row = 0; row < _mapHeight; row++)
            {
                for (int col = 0; col < _mapWidth; col++)
                {
                    var tile = _tiles[row, col];
                    Console.BackgroundColor = (col + row) % 2 == 0 ? ConsoleColor.White : ConsoleColor.Black;
                    Console.Write(tile.TileValue);
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }

        private bool IsValidPosition(int x, int y)
        {
            return x >= 0 && x < _mapWidth && y >= 0 && y < _mapHeight;
        }

        public IEnumerator<Tile> GetEnumerator()
        {
            for (int row = 0; row < _mapHeight; row++)
            {
                for (int col = 0; col < _mapWidth; col++)
                {
                    yield return _tiles[row, col];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }




    //public abstract class Tilemap : IEnumerable<Tile>
    //{

    //    public Tile[,] _tiles;
    //    private int _mapWidth;
    //    private int _mapHeight;

    //    // need to create properties for all the private variables

    //    public int Width => _mapWidth;
    //    public int Height => _mapHeight;


    //    public Tilemap(int width, int height)
    //    {
    //        _mapWidth = width;
    //        _mapHeight = height;
    //        _tiles = new Tile[height, width];
    //        InitializeTiles();
    //    }

    //    private void InitializeTiles()
    //    {
    //        for (int row = 0; row < _mapHeight; row++)
    //        {
    //            for (int col = 0; col < _mapWidth; col++)
    //            {
    //            //    _tiles[row, col] = new Tile();
    //            }
    //        }
    //    }

    //    public void SetTileObject(int x, int y, TileObject tileObject)
    //    {
    //        if (IsValidPosition(x, y))
    //        {
    //          //  _tiles[y, x].OccupyingObject = tileObject;
    //            tileObject.MoveToTile(new int[,] { { x, y } }, null);
    //        }
    //    }

    //    public void AddActor(TileObject actor)
    //    {
    //        // _actors.Add(actor);
    //        Random rand = new Random();
    //        int x, y;
    //       /* do
    //        {
    //            x = rand.Next(Width);
    //            y = rand.Next(Height);
    //        }
    //        while (_tiles[y, x].OccupyingObject != null);
    //        SetTileObject(x, y, actor);*/
    //    }

    //   /* public void HandleTurnOrder()
    //    {
    //        _currentTurn = (_currentTurn + 1) % _actors.Count;
    //        Console.WriteLine($"It's now {_actors[_currentTurn].Name}'s turn.");
    //    }*/

    //    public Tile GetTile(int x, int y)
    //    {
    //        if (IsValidPosition(x, y))
    //        {
    //            return _tiles[y, x];
    //        }
    //        else
    //        {
    //            return null; // need to return to user and let him enter new coordinates 
    //        }
    //    }

    //    public void SetTile(int x, int y, Tile tileValue)
    //    {
    //        if (IsValidPosition(x, y))
    //        {
    //            _tiles[y, x] = tileValue;
    //        }
    //        else
    //        {
    //            // what if a player tries to set in a unvalided position
    //        }
    //    }

    //    public void PrintTilemap() // need to become a set and put print into a visual class
    //    {
    //        for (int row = 0; row < _mapHeight; row++)
    //        {
    //            for (int col = 0; col < _mapWidth; col++)
    //            {
    //                ChessCheckersMapColor(_tiles[col,row], col, row);
    //                if ((row == 0 && (col != 0 && col != (_mapWidth - 1))) || (row == (_mapHeight - 1) && (col != 0 && col != (_mapWidth - 1))))
    //                {
    //                    Console.Write("██"); //Row
    //                }
    //                else if (col == 0 || col == (_mapWidth - 1)) // Colum
    //                {
    //                    Console.Write("██");
    //                }
    //                else if (row != 0 || col != 0)
    //                {
    //                    Console.Write(_tiles[row, col] + "  ");
    //                }
    //            }
    //            Console.WriteLine();
    //        }

    //    }
    //    private bool IsValidPosition(int x, int y)
    //    {
    //        return x >= 0 && x < _mapWidth && y >= 0 && y < _mapHeight;
    //    }




    //    // should all be moved to a color class
    //    private void ColorTile(ConsoleColor color, int col, int row)
    //    {
    //        Console.BackgroundColor = color;
    //    }

    //    private void ChessCheckersMapColor(Tile tile, int col, int row)
    //    {
    //        if ((col + row) % 2 != 0)
    //        {

    //            ColorTile(ConsoleColor.White, col, row);
    //        }
    //        else
    //        {
    //            ColorTile(ConsoleColor.Black, col, row);
    //        }
    //    }


    //    /// IEnumerble and IEnumrator
    //    ///  
    //    ///  
    //    /// 

    //    public IEnumerator<Tile> GetEnumerator()
    //    {
    //        return null;
    //    }

    //    IEnumerator IEnumerable.GetEnumerator()
    //    {
    //        return this.GetEnumerator();
    //    }

    //    /// 
    //    ///  2D Position Interface 
    //    /// 
    //    public struct IPosition
    //    {
    //        // needs to override Must override ToString(), GetHashCode(), and Equals()

    //        public override string ToString()
    //        {
    //            return base.ToString();
    //        }
    //        public override int GetHashCode()
    //        { 
    //           return base.GetHashCode();
    //        }
    //        public override bool Equals([NotNullWhen(true)] object? obj)
    //        {
    //            return base.Equals(obj);
    //        }

    //        // Must override operators for addition and subtraction(+, -)



    //    }
    //}
}
