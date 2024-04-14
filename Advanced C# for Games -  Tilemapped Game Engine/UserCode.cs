using Advanced_C__for_Games____Tilemapped_Game_Engine;
 
class UserMap : Tilemap
{
    public UserMap(int width, int height) : base(width,height)
    {
    

    }
}

class UserEngine : Engine
{

    public UserEngine(Tilemap tilemap, Commends commends) : base(tilemap, commends)
    {



    }
}
