namespace Advanced_C__for_Games____Tilemapped_Game_Engine
{
    class TileObject : Tile
    {
        private string _avatar;
        private string _name; // rook, bishop
        private int[,] _tileLocation;

        public void MoveToTile(int[,] targetTile, int[,] currentTile)
        {
            bool canMove = false;
            // set canMove by checking targetTile and currentTile
            if (true)
            { canMove = true; }
            else return;

            if (canMove) { _tileLocation = targetTile; }
            else return;
        }

        public void Notify(Tile tile)
        {
            if (true /* passing thorugh tiles*/ )
            { }
            if (true /* lands on tiles  tiles*/ )
            { }
        }
        public TileObject(int width, int height, string initialValue, string name, string avatar, int[,] tileLocation) : base(width,height,initialValue)
        {
            this._avatar = avatar;
            this._name = name;
            this._tileLocation = tileLocation;
            avatar = TileValue;
        }
    }
}