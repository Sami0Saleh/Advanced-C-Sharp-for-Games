using System;


namespace Advanced_C__for_Games____Tilemapped_Game_Engine
{
    public class ConsoleRenderer : IRenderer
    {
        public void RenderTile(char left, char center, char right, ConsoleColor foreground, ConsoleColor background)
        {
            left = '[';
            right = ']';
            Console.BackgroundColor = background;
            Console.ForegroundColor = foreground;
            Console.Write(left);
            Console.Write(center);
            Console.Write(right);

            ResetColor();
        }

        public void RenderTileObject(char symbol, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(symbol);

            ResetColor();
        }

        public void RenderTileMap(UserMap tileMap)
        {

        }
        public void ResetColor()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
