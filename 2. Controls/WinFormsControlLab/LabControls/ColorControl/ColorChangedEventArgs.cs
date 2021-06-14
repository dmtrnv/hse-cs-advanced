using System;
using System.Drawing;


namespace LabControls.ColorControl
{
    public class ColorChangedEventArgs : EventArgs
    {
        public Color Color { get; set; }

        public ColorChangedEventArgs(Color color)
        {
            Color = color;
        }
    }
}
