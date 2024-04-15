using System;

namespace Advanced_C__for_Games____Tilemapped_Game_Engine
{
    public class TileMapRenderer
    {
        private IRenderer _renderer;

        public TileMapRenderer()
        {
           
        }

        public void RenderTileMap(UserMap tilemap)
        {
            for (int row = 0; row < tilemap.Height; row++)
            {
                for (int col = 0; col < tilemap.Width; col++)
                {
                    if ((row == 0 && (col != 0 && col != (tilemap.Width - 1))) || (row == (tilemap.Height - 1) && (col != 0 && col != (tilemap.Width - 1))))
                    {
                        Console.Write(tilemap.Tile2DArr[row, col]); //Row
                    }
                    else if (col == 0 || col == (tilemap.Width - 1)) // Colum
                    {
                        Console.Write(tilemap.Tile2DArr[row,col]);
                    }
                    else if (row != 0 || col != 0)
                    {
                        Console.Write(tilemap.Tile2DArr[row, col]);
                    }
                }
                Console.WriteLine();
            }
            // insert logic for rendering a map full of tiles and tile objects

        }
        public void RenderTile(Tile tile)
        {
            //_renderer.RenderTile(tile.Left, tile.Center, tile.Right, tile._foregroundColor, tile._backgroundColor);
        }

        public void RenderTileObject(TileObject tileObject)
        {
            //_renderer.RenderTileObject(tileObject._avatar, tileObject.color);
        }

    }
}

