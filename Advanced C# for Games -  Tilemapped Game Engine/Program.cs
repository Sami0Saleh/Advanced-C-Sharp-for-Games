namespace Advanced_C__for_Games____Tilemapped_Game_Engine
{
    // engine (start and update) 
    // renderer 
    // make existing classes (tilemap, tile, tileobject) abstract and inhertible 

    class Program 
    {
        
        static void Main(string[] args)
        {
           
            TileMapRenderer tileMapRenderer = new TileMapRenderer(); // create renderer
            UserMap userMap = new UserMap(10,10); // create user map
            Commends commends = new Commends(tileMapRenderer);
            UserEngine userEngine = new UserEngine(userMap, commends, tileMapRenderer, userMap);
            userMap.DefineTilemap(); // define user mape
            tileMapRenderer.RenderTileMap(userMap); // render the map


            

         
            Console.WriteLine(userEngine.gameStarted);
            userEngine.StartGame();
            
            Console.WriteLine(userEngine.gameStarted);
       

        }
    }
}