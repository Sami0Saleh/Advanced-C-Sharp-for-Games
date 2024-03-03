namespace Advanced_C__for_Games____Tilemapped_Game_Engine
{
    class TileObject
    {
        private char _avatar;
        private string _name;
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
        public void CheckTile(int[,] targetTile)
        {
            if (/* check if targetTile has another object on it*/true )

                    switch (/*types of _tiles*/ true)
                {
                    default: break;
                }
        }
        public TileObject(string name, char avatar, int[,] tileLocation)
        {
            this._avatar = avatar;
            this._name = name;
            this._tileLocation = tileLocation;
        }
    }
}