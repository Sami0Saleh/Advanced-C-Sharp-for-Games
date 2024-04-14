﻿namespace Advanced_C__for_Games____Tilemapped_Game_Engine
{
    // engine (start and update) 
    // renderer 
    // make existing classes (tilemap, tile, tileobject) abstract and inhertible 
    class Program 
    {
       
        static void Main(string[] args)
        {

            UserMap userMap = new UserMap(10,10);
            Commends commends = new Commends();
            UserEngine userEngine = new UserEngine(userMap, commends);
            Console.WriteLine(userEngine.gameStarted);
            userEngine.StartGame();
            Console.WriteLine(userEngine.gameStarted);
            userEngine.StopGame();
        }
    }
}