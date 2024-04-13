using Advanced_C__for_Games____Tilemapped_Game_Engine;
using System.Security.Cryptography.X509Certificates;

public abstract class Engine // needs to support inhertience 
{
    private Tilemap _tileMap;
    private Commends commends;

    public bool engineStarted = false;
    // private Renderer _renderer;
    public void StartGame() // Starts The Game 
    {
        engineStarted = true;
        Console.WriteLine("Engine Start");
        commends.CommendLine();
    }

    public void Update() // runs until game ends handles moving parts
    {
        while (engineStarted)
        {



        }
    }

    public void StopGame() // stops the game
    {
       
            engineStarted = false;

    }
    public void TurnHandler(Actor player, Actor AI) //  handles the diffrent turns of the actors
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

    public void LoadTileMap(Tilemap tilemap) // used to load tile maps into memory
    {
        _tileMap = tilemap;
    }

    public void PlaceTileObjects() // places tiles objects on tiles on the map
    {

    }

    public void LoadActors() // load player and AI into the game
    {

    }

    // Constructor 
    public Engine(Tilemap tilemap, Commends commends)
    {
        this._tileMap = tilemap;
        this.commends = commends;
    }
   
    
 


}
