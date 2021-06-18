using System;
using System.ComponentModel;
using System.Windows.Forms;


namespace MDIPaint
{
    public partial class CanvasSizeTextBox : TextBox
    {
        public int Value { get; private set; }

        public CanvasSizeTextBox()
        {
            InitializeComponent();
        }

        public CanvasSizeTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            if (int.TryParse(Text, out var value))
            {
                Value = value <= 0 ? 1 : value;
            }
            else
            {
                Value = 0;
                Text = Value.ToString();
            }

            base.OnTextChanged(e);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            base.OnKeyPress(e);
        }
    }
}
