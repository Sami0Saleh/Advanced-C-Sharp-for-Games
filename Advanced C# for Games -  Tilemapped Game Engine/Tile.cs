﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C__for_Games____Tilemapped_Game_Engine
{
    public abstract class Tile : ICloneable
    {
        public int ID { get; private set; }
        public int[,] Position { get; private set; }
        public ConsoleColor _backgroundColor;
        public ConsoleColor _foregroundColor;
        public char Left;
        public char Center;
        public char Right;
        private Actor _actor; // the actor the tile belongs to 
        private TileObject _tileObject = null;
        private string _tileValue = "  ";  // get from tile object obtaining it, if empty is 2 spaces

        public string TileValue
        {
            get { return _tileValue; }
            set { _tileValue = value; }
        }

        
        public Tile(int id, int row, int col, string initialValue)
        {
            ID = id;
            Position = new int[,] { { row, col } };
            _tileValue = initialValue;
        }

        
        public bool IsOccupied()
        {
            return _tileValue != null;
        }

        
        public bool OccupyTile()
        {
            if (!IsOccupied())
            {
                _tileValue = "  "; 
                return true;
            }
            else
            {
                return false; 
            }
        }

        
        public void VacateTile()
        {
            _tileValue = "  ";
        }

        public void Notify(TileObject tileobject)
        {
            if (true )
            { }
            if (true )
            { }
        }

        public abstract object Clone();
    }




 //   tile.Left, tile.Center, tile.Right, tile.ForegroundColor, tile.BackgroundColor
 //    public abstract class Tile : ICloneable
 //    {
 //        public ConsoleColor _backgroundColor;
 //        public ConsoleColor _foregroundColor;
 //        public char Left;
 //        public char Center;
 //        public char Right;



//        private Actor _actor; // the actor the tile belongs to 

//        private TileObject _tileObject = null;
//        private string _tileValue = "  ";  // get from tile object obtaining it, if emptey is 2 spaces
//        // tile class should know what position hes in
//        private string actor;
//        public string TileValue
//        {
//            get { return _tileValue; }
//            set { _tileValue = value; }
//        }

//        // Method to check if the tile is occupied
//        public bool IsOccupied()
//        {          
//            return _tileValue != null;
//        }

//        // Method to occupy the tile with a tile object
//        public bool OccupyTile()
//        {
//            if (!IsOccupied())
//            {
//                _tileValue = "  "; // Arbitrarily assigning 1 to represent an occupied tile
//                return true;
//            }
//            else
//            {
//                return false; // Tile is already occupied
//            }
//        }

//        // Method to vacate the tile
//        public void VacateTile()
//        {

//            _tileValue = "  "; // Resetting the tile value to represent an unoccupied tile
//        }



//        public void Notify(TileObject tileobject)
//        {
//            if (true /* passing thorugh tiles*/ )
//            { }
//            if (true /* lands on tiles  tiles*/ )
//            { }
//        }
//        public Tile(string initialValue)
//        {
//            _tileValue = initialValue;
//        }

//        public abstract object Clone();
//    }
//}
