using System;

public class TileMapRenderer
{
    private IRenderer _renderer;

    public TileMapRenderer(IRenderer renderer)
    {
        _renderer = renderer;
    }

    public void RenderTile(Tile tile)
    {
        _renderer.RenderTile(tile.Left, tile.Center, tile.Right, tile.ForegroundColor, tile.BackgroundColor);
    }

    public void RenderTileObject(TileObject tileObject)
    {
        _renderer.RenderTileObject(tileObject.Symbol, tileObject.Color);
    }
}

