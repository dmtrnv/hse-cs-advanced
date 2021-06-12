using System;
using System.Drawing;
using PluginInterface;


namespace DatePlugin
{
    [Version(1, 0, 0)]
    public class DatePlugin : IPlugin
    {
        public string Name 
            => "Date";

        public string Author
            => "Dmitry Renev";

        public void Transform(Bitmap currentImage)
        {
            using (var graphics = Graphics.FromImage(currentImage))
            {
                var date = DateTime.Now.ToLongDateString();
                var fontSize = 9.0f;

                graphics.DrawString(
                    date, 
                    new Font(FontFamily.GenericSerif, fontSize), 
                    Brushes.AliceBlue, 
                    currentImage.Width - (date.Length * fontSize) - 5, 
                    currentImage.Height - (fontSize * 3));
            }
        }
    }
}
