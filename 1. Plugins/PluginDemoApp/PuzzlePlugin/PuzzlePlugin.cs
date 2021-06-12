using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using PluginInterface;


namespace PuzzlePlugin
{
    [Version(1, 0, 0)]
    public class PuzzlePlugin : IPlugin
    {
        private static Random random = new Random();
        private List<Color[,]> _blocks;

        public string Name 
            => "Puzzle";

        public string Author
            => "Dmitry Renev";

        public void Transform(Bitmap currentImage)
        {
            // Переменная blocksCount должна быть квадратом целого числа.
            var blocksCount = 9;
            var tableSize = (int)Math.Sqrt(blocksCount);
            var blockWidth = currentImage.Width / tableSize;
            var blockHeight = currentImage.Height / tableSize;

            _blocks = currentImage.GetBlocks(tableSize, blockWidth, blockHeight);
            _blocks = _blocks.OrderBy(b => random.Next()).ToList();

            PuzzleCurrentImage(currentImage, _blocks, tableSize, blockWidth, blockHeight);
        }

        private void PuzzleCurrentImage(Bitmap image, List<Color[,]> blocks, int tableSize, int blockWidth, int blockHeight)
        {
            var index = 0;

            for (var i = 0; i < tableSize; i++)
            {
                for (var j = 0; j < tableSize; j++)
                {
                    for (int k = 0, x = i * blockWidth; k < blockWidth; k++, x++)
                    {
                        for (int z = 0, y = j * blockHeight; z < blockHeight; z++, y++)
                        {
                            image.SetPixel(x, y, blocks[index][k, z]);
                        }
                    }

                    index++;
                }
            }
        }
    }  
}
