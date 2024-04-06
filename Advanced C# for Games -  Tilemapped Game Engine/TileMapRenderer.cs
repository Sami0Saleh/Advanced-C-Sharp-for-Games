using System;

namespace Advanced_C__for_Games____Tilemapped_Game_Engine
{
    public class TileMapRenderer
    {
        private IRenderer _renderer;

        public TileMapRenderer(IRenderer renderer)
        {
            _renderer = renderer;
        }

        public void RenderMap(Tilemap tilemap)
        {
            foreach (var tile in tilemap._tiles)
            {
                RenderTile(tile);
            }

            // insert logic for rendering a map full of tiles and tile objects

        }
        public void RenderTile(Tile tile)
        {
            _renderer.RenderTile(tile.Left, tile.Center, tile.Right, tile._foregroundColor, tile._backgroundColor);
        }

        public void RenderTileObject(TileObject tileObject)
        {
            _renderer.RenderTileObject(tileObject._avatar, tileObject.color);
        }

    }
}

