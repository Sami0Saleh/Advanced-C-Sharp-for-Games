using System;


namespace Advanced_C__for_Games____Tilemapped_Game_Engine
{
    public class Commends
    {
        TileObject _selectedTO;
        
        public void CommendLine()
        {
            Console.WriteLine("Please Enter A Commend");
            string commend = Console.ReadLine();
            
            switch (commend)
            {
                case "/help":  Help(); break;
                case "/play": break;
                case "/stop": break;
                case "/select": Select(); break;
                case "/deselect": Deselect(); break;
                case "/move": Move(); break;

            }

        }

        public void Help()
        {
            Console.WriteLine("/help");
            Console.WriteLine("/play");
            Console.WriteLine("/stop");
            Console.WriteLine("/select");
            Console.WriteLine("/deselect");
            Console.WriteLine("/move");
       
            // should also print out user codes as well
            }

        public void Select()
        {

        }
        public void Deselect()
        {

        }
        public void Move()
        {

        }







        public Commends() 
        {
        
        }


    }
}

