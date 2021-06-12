using System.Drawing;
using PluginInterface;


namespace GrayscalePlugin
{
    [Version(1, 0, 0)]
    public class GrayscalePlugin : IPlugin
    {
        public string Name 
            => "Grayscale";

        public string Author
            => "Dmitry Renev";

        public void Transform(Bitmap currentImage)
        {
            for (var i = 0; i < currentImage.Width; i++)
            {
                for (var j = 0; j < currentImage.Height; j++)
                {
                    var originalColor = currentImage.GetPixel(i, j);
                    var grayscaleColor = (int)((0.2126 * originalColor.R) + (0.7152 * originalColor.G) + (0.0722 * originalColor.B));
                    currentImage.SetPixel(i, j, Color.FromArgb(grayscaleColor, grayscaleColor, grayscaleColor));
                }
            }
        }
    }
}
