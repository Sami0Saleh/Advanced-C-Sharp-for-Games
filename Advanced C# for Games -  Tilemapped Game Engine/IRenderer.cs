using System;

namespace Advanced_C__for_Games____Tilemapped_Game_Engine
{
    public interface IRenderer
    {
        void RenderTile(char left, char center, char right, ConsoleColor foreground, ConsoleColor background);
        void RenderTileObject(char symbol, ConsoleColor color);
    }
}
