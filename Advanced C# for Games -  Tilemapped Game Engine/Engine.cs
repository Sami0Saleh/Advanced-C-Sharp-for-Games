using Advanced_C__for_Games____Tilemapped_Game_Engine;

public abstract class Engine // needs to support inhertience 
{
    private Tilemap _tileMap;

    // private Renderer _renderer;
    public void StartGame() // Starts The Game 
    {
        
    }

    public void Update() // runs until game ends handles moving parts
    {


    }

    public void TurnHandler() //  handles the diffrent turns of the actors
    {

    }
    public void StopGame() // stops the game
    {


    }
   
    public Tile TileCreator() // used to create tiles
    {
        return null;
    }

    public TileObject TileObjectCreator() // used to create tile objects
    {

        return null;
    }

    public void LoadTileMap() // used to load tile maps into memory
    {

    }

    public void PlaceTileObjects() // places tiles objects on tiles on the map
    {

    }

    public void LoadActors() // load player and AI into the game
    {

    }





    // Constructor 
    public Engine(Tilemap tilemap)
    {
        this._tileMap = tilemap;
    }


}