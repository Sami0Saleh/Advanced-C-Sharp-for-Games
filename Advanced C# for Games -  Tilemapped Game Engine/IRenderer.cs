using System;

public interface IRenderer
{
    void RenderTile(char left, char center, char right, ConsoleColor foreground, ConsoleColor background);
    void RenderTileObject(char symbol, ConsoleColor color);
}
