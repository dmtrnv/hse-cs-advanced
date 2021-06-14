using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace LabControls
{
    public partial class NumberBox : TextBox
    {
        public NumberBox()
        {
            InitializeComponent();
        }

        public NumberBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            ForeColor = !double.TryParse(Text, out _) ? Color.Red : Color.Black;

            base.OnTextChanged(e);
        }
    }
}
