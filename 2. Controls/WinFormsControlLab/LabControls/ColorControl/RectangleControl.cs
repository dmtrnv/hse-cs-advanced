using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace LabControls.ColorControl
{
    public partial class RectangleControl : Control
    {
        private Color _color = Color.Black;

        public Color Color
        {
            get => _color;

            set
            {
                _color = value;
                Invalidate();
            }
        }

        public RectangleControl()
        {
            InitializeComponent();
        }

        public RectangleControl(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color), ClientRectangle);

            base.OnPaint(e);
        }
    }
}
