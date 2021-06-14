using System;
using System.Drawing;
using System.Windows.Forms;


namespace LabControls.ColorControl
{
    public partial class ColorControl : UserControl
    {
        public event EventHandler<ColorChangedEventArgs> RectangleControlColorChanged;

        public Color RectangleControlColor
        {
            get => rectangleControl.Color;

            set
            {
                rectangleControl.Color = value;
                RectangleControlColorChanged?.Invoke(this, new ColorChangedEventArgs(rectangleControl.Color));
            }
        }
        
        public ColorControl()
        {
            InitializeComponent();

            RectangleControlColor = Color.Violet;
            colorNumberBoxRed.Text = RectangleControlColor.R.ToString();
            colorNumberBoxGreen.Text = RectangleControlColor.G.ToString();
            colorNumberBoxBlue.Text = RectangleControlColor.B.ToString();

            colorNumberBoxRed.TextChanged += OnColorNumberBoxTextChanged;
            colorNumberBoxGreen.TextChanged += OnColorNumberBoxTextChanged;
            colorNumberBoxBlue.TextChanged += OnColorNumberBoxTextChanged;
        }

        private void OnRadioBtnDecCheckedChanged(object sender, EventArgs e)
        {
            if (colorNumberBoxRed.CurrentNumberSystem == NumberSystem.Hexadecimal)
            {
                colorNumberBoxRed.CurrentNumberSystem = NumberSystem.Decimal;
                colorNumberBoxGreen.CurrentNumberSystem = NumberSystem.Decimal;
                colorNumberBoxBlue.CurrentNumberSystem = NumberSystem.Decimal;

                colorNumberBoxRed.SetTextToDec();
                colorNumberBoxGreen.SetTextToDec();
                colorNumberBoxBlue.SetTextToDec();
            }
        }

        private void OnRadioBtnHexCheckedChanged(object sender, EventArgs e)
        {
            if (colorNumberBoxRed.CurrentNumberSystem == NumberSystem.Decimal)
            {
                colorNumberBoxRed.CurrentNumberSystem = NumberSystem.Hexadecimal;
                colorNumberBoxGreen.CurrentNumberSystem = NumberSystem.Hexadecimal;
                colorNumberBoxBlue.CurrentNumberSystem = NumberSystem.Hexadecimal;

                colorNumberBoxRed.SetTextToHex();
                colorNumberBoxGreen.SetTextToHex();
                colorNumberBoxBlue.SetTextToHex();
            }
        }

        private void OnColorNumberBoxTextChanged(object sender, EventArgs e)
        {
            RectangleControlColor = Color.FromArgb(colorNumberBoxRed.Value, colorNumberBoxGreen.Value, colorNumberBoxBlue.Value);
        }
    }
}
