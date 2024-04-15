using Advanced_C__for_Games____Tilemapped_Game_Engine;
using System.Diagnostics;
using System.Threading;

public abstract class Engine // needs to support inhertience 
{
    private Tilemap _tileMap;
    private Commends commends;

    public bool gameStarted = false;
    // private Renderer _renderer;
    public void StartGame() // Starts The Game 
    {
        gameStarted = true;
        Console.WriteLine("Engine Start");
        commends.CommendLine();
        Update();
    }

    public void Update() // runs until game ends handles moving parts
    {
        int lastTime = 0;
        var watch = Stopwatch.StartNew();
        watch.Start();
        while (gameStarted)
        {

            lastTime = EngineTimer(watch, lastTime);
            if (Console.KeyAvailable)
            { 
            ConsoleKeyInfo playerInput = Console.ReadKey(true);
            switch (playerInput.Key)
            {
                case ConsoleKey.Escape: StopGame(); break;
                case ConsoleKey.Tab: commends.CommendLine(); break;
                default: Console.WriteLine("Unknown Key"); break;
            }
            }
        }
    }

    public void StopGame() // stops the game
    {
        if (gameStarted)
        {
            Console.WriteLine("Engine Stopped");
            gameStarted = false;
        }
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
        LoadTileMap(tilemap);
        this.commends = commends;
    }
   
    public int EngineTimer(Stopwatch watch, int lastTime)
    {
        
        if (watch.Elapsed.Seconds != lastTime)
        {
            Console.WriteLine($"Run Time - {watch.Elapsed.Hours}:{watch.Elapsed.Minutes}:{watch.Elapsed.Seconds}");
        }
        lastTime = watch.Elapsed.Seconds;
        return lastTime;
    }
 


}
