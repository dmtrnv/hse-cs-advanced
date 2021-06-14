using System.Windows.Forms;
using LabControls.ColorControl;


namespace TestControlsApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            rectangleControl.Color = colorControl.RectangleControlColor;
        }

        private void OnColorControlRectangleControlColorChanged(object sender, ColorChangedEventArgs e)
        {
            rectangleControl.Color = e.Color;
        }
    }
}
