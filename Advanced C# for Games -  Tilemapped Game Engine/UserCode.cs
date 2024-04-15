using Advanced_C__for_Games____Tilemapped_Game_Engine;

public class UserMap : Tilemap
{
    private int _mapWidth;
    private int _mapHeight;
    private string[,] _tile2DArr = new string[,] { };

    public string[,] Tile2DArr
    {
        get { return _tile2DArr; }
        protected set {  _tile2DArr = value; }    
    }
public void DefineTilemap() // need to become a set and put print into a visual class
        {
        for (int row = 0; row < _mapHeight; row++)
        {
            for (int col = 0; col < _mapWidth; col++)
            {
                //ChessCheckersMapColor(_tiles[col, row], col, row);
                if ((row == 0 && (col != 0 && col != (_mapWidth - 1))) || (row == (_mapHeight - 1) && (col != 0 && col != (_mapWidth - 1))))
                {
                    _tile2DArr[col, row] = "AA";//Row"██"
                }
                else if (col == 0 || col == (_mapWidth - 1)) // Colum
                {
                    _tile2DArr[col, row] = "██";
                }
                else if (row != 0 || col != 0)
                {
                    _tile2DArr[col, row] = "  ";
                }
                
            }
            
        }

    }
    public UserMap(int width, int height) : base(width,height)
    {
        _mapWidth = width;
        _mapHeight = height;
        _tile2DArr = new string[_mapWidth, _mapHeight];
    }
}

class UserEngine : Engine
{

    public UserEngine(Tilemap tilemap, Commends commends) : base(tilemap, commends)
    {



    }
}
