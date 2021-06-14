using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;


namespace LabControls.ColorControl
{
    public partial class ColorNumberBox : TextBox
    {
        public NumberSystem CurrentNumberSystem { get; set; }
        public int Value { get; private set; }

        public ColorNumberBox()
        {
            InitializeComponent();
        }

        public ColorNumberBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void SetTextToDec()
        {
            Text = Value.ToString();
        }

        public void SetTextToHex()
        {
            Text = Value.ToString("X");
        }

        protected override void OnTextChanged(EventArgs e)
        {
            switch (CurrentNumberSystem)
            {
                case NumberSystem.Decimal:
                    ParseDecimalValue();
                    break;

                case NumberSystem.Hexadecimal:
                    ParseHexadecimalValue();
                    break;
            }

            base.OnTextChanged(e);
        }

        private void ParseDecimalValue()
        {
            if (int.TryParse(Text, out var value))
            {
                if (value < 0)
                {
                    Value = 0;
                    SetTextToDec();
                }
                else if (value > 255)
                {
                    Value = 255;
                    SetTextToDec();
                }
                else
                {
                    Value = value;
                }
            }
        }

        private void ParseHexadecimalValue()
        {
            if (int.TryParse(Text, NumberStyles.HexNumber, null, out var decValue))
            {
                if (decValue < 0)
                {
                    Value = 0;
                    SetTextToHex();
                }
                else if (decValue > 255)
                {
                    Value = 255;
                    SetTextToHex();
                }
                else
                {
                    Value = decValue;
                }
            }
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            switch (CurrentNumberSystem)
            {
                case NumberSystem.Decimal:
                    if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                    break;

                case NumberSystem.Hexadecimal:
                    if (!Uri.IsHexDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                    break;
            }

            base.OnKeyPress(e);
        }
    }
}