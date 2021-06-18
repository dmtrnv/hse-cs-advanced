using System.Windows.Forms;


namespace MDIPaint
{
    public partial class CanvasSize : Form
    {
        public int CanvasWidth
        {
            get => canvasSizeTextBoxWidth.Value;

            set => canvasSizeTextBoxWidth.Text = value.ToString();
        }
        
        public int CanvasHeight
        {
            get => canvasSizeTextBoxHeight.Value;

            set => canvasSizeTextBoxHeight.Text = value.ToString();

        }

        public CanvasSize()
        {
            InitializeComponent();
        }
    }
}
