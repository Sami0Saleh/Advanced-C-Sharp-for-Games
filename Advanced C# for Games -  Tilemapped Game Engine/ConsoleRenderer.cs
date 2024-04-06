using System;

public class ConsoleRenderer : IRenderer
{
    public void RenderTile(char left, char center, char right, ConsoleColor foreground, ConsoleColor background)
    {
        Console.BackgroundColor = background;
        Console.ForegroundColor = foreground;
        Console.Write(left);
        Console.Write(center);
        Console.Write(right);
    }

    public void RenderTileObject(char symbol, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.Write(symbol);
    }
}
