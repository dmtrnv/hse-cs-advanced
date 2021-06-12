using System.Collections.Generic;
using System.Drawing;


namespace PuzzlePlugin
{
    public static class BitmapExtensions
    {
        public static List<Color[,]> GetBlocks(this Bitmap image, int tableSize, int blockWidth, int blockHeight)
        {
            var blocks = new List<Color[,]>(tableSize * tableSize);

            for (var i = 0; i < tableSize; i++)
            {
                for (var j = 0; j < tableSize; j++)
                {
                    var block = new Color[blockWidth, blockHeight];

                    for (int k = 0, x = i * blockWidth; k < blockWidth; k++, x++)
                    {
                        for (int z = 0, y = j * blockHeight; z < blockHeight; z++, y++)
                        {
                            block[k, z] = image.GetPixel(x, y);
                        }
                    }

                    blocks.Add(block);
                }
            }

            return blocks;
        }
    }
}
