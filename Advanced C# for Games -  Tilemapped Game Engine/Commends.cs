using System;


namespace Advanced_C__for_Games____Tilemapped_Game_Engine
{
    public class Commends
    {
        public void CommendLine()
        {
            Console.WriteLine("Please Enter A Commend");
            string commend = Console.ReadLine();
            
            switch (commend)
            {
                case "/help":  Help(); break;
                case "/play": break;
                case "/stop": break;






            }









        }

        public void Help()
        {
            Console.WriteLine("All commends printed here");
        }









        public Commends() { }


    }
}

