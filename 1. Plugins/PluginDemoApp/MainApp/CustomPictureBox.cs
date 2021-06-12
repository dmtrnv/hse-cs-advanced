using System;
using System.Windows.Forms;
using System.Drawing;


namespace MainApp
{
    public class CustomPictureBox : PictureBox
    {
        public event EventHandler<CustomPictureBoxEventArgs> ImageChanged;

        public new Image Image
        {
            get => base.Image;

            set
            {
                base.Image = value;
                ImageChanged?.Invoke(this, new CustomPictureBoxEventArgs(value.Width, value.Height));
            }
        }
    }

    public class CustomPictureBoxEventArgs : EventArgs
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public CustomPictureBoxEventArgs(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }
}
