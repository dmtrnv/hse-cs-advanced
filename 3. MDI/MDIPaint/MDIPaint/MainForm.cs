using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;


namespace MDIPaint
{
    public partial class MainForm : Form
    {
        public static Color CurrentColor { get; set; } = Color.Black;

        public static int CurrentPenThickness { get; private set; } = 1;

        public static Tool CurrentTool { get; private set; } = Tool.Pen;

        public static int CurrentStarNPoints { get; private set; }

        /// <summary>
        /// Используется для корректного изменения свойства Checked у кнопок выбора цвета.
        /// </summary>
        private readonly ToolStripButton[] _colorButtons;

        /// <summary>
        /// Используется для корректного изменения свойства Checked у кнопок выбора инструмента.
        /// </summary>
        private readonly ToolStripButton[] _toolButtons;

        public MainForm()
        {
            InitializeComponent();

            penToolStripButton.Checked = true;
            blackColorToolStripButton.Checked = true;
            penThicknes1ToolStripMenuItem.Checked = true;

            _colorButtons = new ToolStripButton[]
            {
                blackColorToolStripButton, 
                redColorToolStripButton, 
                greenColorToolStripButton, 
                blueColorToolStripButton, 
                colorPaletteToolStripButton
            };

            _toolButtons = new ToolStripButton[]
            {
                penToolStripButton,
                lineToolStripButton,
                rectangleToolStripButton,
                ellipseToolStripButton,
                eraserToolStripButton
            };
        }

        private void OnHelpAboutProgramToolStripMenuItemClick(object sender, EventArgs e)
        {
            var formAbout = new AboutPaint();
            formAbout.ShowDialog();
        }

        private void OnFileExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnFileNewToolStripMenuItemClick(object sender, EventArgs e)
        {
            var formChild = new Canvas { MdiParent = this };
            formChild.Show();
        }

        private void OnPictureToolStripMenuItemDropDownOpening(object sender, EventArgs e)
        {
            pictureSizeToolStripMenuItem.Enabled = ((ActiveMdiChild != null) && !((Canvas)ActiveMdiChild).IsZoomed());
        }

        /// <summary>
        /// Вызывает диалоговое окно для изменения размера "холста".
        /// При удачном закрытии изменяет размер "холста".
        /// </summary>
        private void OnPictureSizeToolStripMenuItemClick(object sender, EventArgs e)
        {
            var activeMdiChild = (Canvas)ActiveMdiChild;

            using (var canvasSize = new CanvasSize())
            {
                canvasSize.CanvasWidth = activeMdiChild.CanvasWidth;
                canvasSize.CanvasHeight = activeMdiChild.CanvasHeight;

                if (canvasSize.ShowDialog() == DialogResult.OK)
                {
                    activeMdiChild.CanvasWidth = canvasSize.CanvasWidth;
                    activeMdiChild.CanvasHeight = canvasSize.CanvasHeight;
                }
            }
        }

        private void OnBlackColorToolStripButtonClick(object sender, EventArgs e)
        {
            CurrentColor = Color.Black;
        }

        private void OnRedColorToolStripButtonClick(object sender, EventArgs e)
        {
            CurrentColor = Color.Red;
        }

        private void OnGreenColorToolStripButtonClick(object sender, EventArgs e)
        {
            CurrentColor = Color.Green;
        }

        private void OnBlueColorToolStripButtonClick(object sender, EventArgs e)
        {
            CurrentColor = Color.Blue;
        }

        private void OnColorPalletteToolStripButtonClick(object sender, EventArgs e)
        {
            using (var colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    CurrentColor = colorDialog.Color;
                }
            }
        }

        private void OnPenThicknessToolStripDropDownButtonDropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            CurrentPenThickness = int.Parse(e.ClickedItem.Text);

            var clikedItem = (ToolStripMenuItem)e.ClickedItem;

            foreach (ToolStripMenuItem item in penThicknessToolStripDropDownButton.DropDownItems)
            {
                item.Checked = (item == clikedItem);
            }
        }

        private void OnPenToolStripButtonClick(object sender, EventArgs e)
        {
            CurrentTool = Tool.Pen;
        }

        private void OnLineToolStripButtonClick(object sender, EventArgs e)
        {
            CurrentTool = Tool.Line;
        }

        private void OnRectangleToolStripButtonClick(object sender, EventArgs e)
        {
            CurrentTool = Tool.Rectangle;
        }

        private void OnEllipseToolStripButtonClick(object sender, EventArgs e)
        {
            CurrentTool = Tool.Ellipse;
        }

        private void OnEraserToolStripButtonClick(object sender, EventArgs e)
        {
            CurrentTool = Tool.Eraser;
        }

        private void OnNPointedStarToolStripDropDownButtonDropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            CurrentTool = Tool.NPointedStar;
            CurrentStarNPoints = int.Parse(e.ClickedItem.Text);

            var clickedItem = (ToolStripMenuItem)e.ClickedItem;

            foreach (ToolStripMenuItem item in nPointedStarToolStripDropDownButton.DropDownItems)
            {
                item.Checked = (item == clickedItem);
            }

            // Отключение свойства Checked у остальных инструментов.
            foreach (var toolButton in _toolButtons)
            {
                toolButton.Checked = false;
            }
        }

        private void OnFileOpenToolStripMenuItemClick(object sender, EventArgs e)
        {
            using (var openDialog = new OpenFileDialog())
            {
                openDialog.Filter = "Файлы изображений |*.jpg;*.jpeg;*.png;*.bmp";
                openDialog.Title = "Выбрать изображение";

                var imageFormats = new ImageFormat[] { ImageFormat.Jpeg, ImageFormat.Png, ImageFormat.Bmp };
                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    var formChild = new Canvas(openDialog.FileName) { MdiParent = this };
                    
                    formChild.Show();
                }
            }   
        }

        private void OnFileSaveToolStripMenuItemClick(object sender, EventArgs e)
        {
            ((Canvas)ActiveMdiChild).Save();
        }

        private void OnFileSaveAsToolStripMenuItemClick(object sender, EventArgs e)
        {
            ((Canvas)ActiveMdiChild).SaveAs();
        }

        private void OnFileToolStripMenuItemDropDownOpening(object sender, EventArgs e)
        {
            fileSaveToolStripMenuItem.Enabled = (ActiveMdiChild != null);
            fileSaveAsToolStripMenuItem.Enabled = (ActiveMdiChild != null);
        }

        private void OnWindowCascadeToolStripMenuItemClick(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void OnWindowLeftToRightToolStripMenuItemClick(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void OnWindowUpToBottomToolStripMenuItemClick(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void OnWindowArrangeIconsToolStripMenuItemClick(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void OnZoomInToolStripButtonClick(object sender, EventArgs e)
        {
            ((Canvas)ActiveMdiChild).OnMainFormZoomInClick();

            zoomInToolStripButton.Enabled = ((ActiveMdiChild != null) && !((Canvas)ActiveMdiChild).IsZoomMax());
            zoomOutToolStripButton.Enabled = ((ActiveMdiChild != null) && ((Canvas)ActiveMdiChild).IsZoomed());
        }

        private void OnZoomOutToolStripButtonClick(object sender, EventArgs e)
        {
            ((Canvas)ActiveMdiChild).OnMainFormZoomOutClick();

            zoomInToolStripButton.Enabled = ((ActiveMdiChild != null) && !((Canvas)ActiveMdiChild).IsZoomMax());
            zoomOutToolStripButton.Enabled = ((ActiveMdiChild != null) && ((Canvas)ActiveMdiChild).IsZoomed());
        }

        private void OnMainFormMdiChildActivate(object sender, EventArgs e)
        {
            zoomInToolStripButton.Enabled = ((ActiveMdiChild != null) && !((Canvas)ActiveMdiChild).IsZoomMax());
            zoomOutToolStripButton.Enabled = ((ActiveMdiChild != null) && ((Canvas)ActiveMdiChild).IsZoomed());
        }

        /// <summary>
        /// Измененяет свойства Checked у кнопок выбора цвета и кнопок выбора инструмента.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnToolStripItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem is ToolStripButton button)
            {
                if (_colorButtons.Contains(button))
                {
                    foreach (var colorButton in _colorButtons)
                    {
                        colorButton.Checked = (colorButton == button);
                    }
                }
                else if (_toolButtons.Contains(button))
                {
                    foreach (var toolButton in _toolButtons)
                    {
                        toolButton.Checked = (toolButton == button);
                    }

                    foreach (ToolStripMenuItem item in nPointedStarToolStripDropDownButton.DropDownItems)
                    {
                        item.Checked = false;
                    }
                }
            }
        }
    }
}
