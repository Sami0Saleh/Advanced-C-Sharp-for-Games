namespace Advanced_C__for_Games____Tilemapped_Game_Engine
{
    public class PrintTilemapClass : Tilemap
    {
        private int _width;
        private int _height;
        private Tilemap _tileMap;


        public void PrintTilemap() // need to become a set and put print into a visual class
        {
            for (int row = 0; row < _height; row++)
            {
                for (int col = 0; col < _width; col++)
                {
                    ChessCheckersMapColor(tiles[col, row], col, row);
                    if ((row == 0 && (col != 0 && col != (_width - 1))) || (row == (_height - 1) && (col != 0 && col != (_width - 1))))
                    {
                        // ██
                        Console.Write($"{col} "); //Row
                    }
                    else if (col == 0 || col == (_width - 1)) // Colum
                    {

                        Console.Write($"{row} ");
                    }
                    else if (row != 0 || col != 0)
                    {
                        Console.Write(tiles[row, col] + $"{col}{row}");
                    }
                }
                Console.WriteLine();
            }

        }
        private void ChessCheckersMapColor(string tile, int col, int row)
        {
            if ((col + row) % 2 != 0)
            {

                ColorTile(ConsoleColor.White, col, row);
            }
            else
            {
                ColorTile(ConsoleColor.Black, col, row);
            }
        }
        // should all be moved to a color class
        private void ColorTile(ConsoleColor color, int col, int row)
        {
            Console.BackgroundColor = color;
        }
        public PrintTilemapClass(int width, int height, Tilemap tilemap) : base(width, height)
        {
            _tileMap = tilemap;

        }

    }
}