using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;


namespace MDIPaint
{
    public partial class Canvas : Form
    {
        /// <summary>
        /// Координата X мыши, которая изменяется при нажатии левой кнопкой на pictureBox.
        /// </summary>
        private int _oldX;

        /// <summary>
        /// Координата Y мыши, которая изменяется при нажатии левой кнопкой на pictureBox.
        /// </summary>
        private int _oldY;

        /// <summary>
        /// Используется для хранения переменных значений изображения.
        /// </summary>
        private Bitmap _temporaryBitmap;

        /// <summary>
        /// Используется для хранения значений текущего изображения, которе отражается в pictureBox. 
        /// </summary>
        private Bitmap _bitmap;

        /// <summary>
        /// Используется для корректной работы изменения масштаба.
        /// </summary>
        private Bitmap _originalBitmap;
        
        private ImageFormat _imageFormat;

        private bool _imageWasChanged = false;

        private string _fileName = string.Empty;

        private int _zoomValue = 1;

        private int _maxZoomValue = 4;

        public int CanvasWidth
        {
            get => pictureBox.Width;

            set
            {
                if (pictureBox.Width != value)
                {
                    _temporaryBitmap = new Bitmap(value, pictureBox.Height);
                    using (var g = Graphics.FromImage(_temporaryBitmap))
                    {
                        g.Clear(pictureBox.BackColor);
                        g.DrawImage(_bitmap, 0, 0);
                    }

                    _bitmap?.Dispose();

                    _bitmap = _temporaryBitmap;
                    _originalBitmap = _bitmap;
                    pictureBox.Image = _bitmap;
                    _imageWasChanged = true;

                    SetClientSizeCore(_bitmap.Width, _bitmap.Height);
                }
            }
        }

        public int CanvasHeight
        {
            get => pictureBox.Height;

            set
            {
                if (pictureBox.Height != value)
                {
                    _temporaryBitmap = new Bitmap(pictureBox.Width, value);
                    using (var g = Graphics.FromImage(_temporaryBitmap))
                    {
                        g.Clear(pictureBox.BackColor);
                        g.DrawImage(_bitmap, 0, 0);
                    }
                    
                    _bitmap?.Dispose();

                    _bitmap = _temporaryBitmap;
                    _originalBitmap = _bitmap;
                    pictureBox.Image = _bitmap;
                    _imageWasChanged = true;

                    SetClientSizeCore(_bitmap.Width, _bitmap.Height);
                }
            }
        }

        public Canvas()
        {
            InitializeComponent();
            
            _bitmap = new Bitmap(ClientSize.Width, ClientSize.Height);

            using (var g = Graphics.FromImage(_bitmap))
            {
                g.Clear(pictureBox.BackColor);
            }

            _originalBitmap = _bitmap;
            pictureBox.Image = _bitmap;
        }

        public Canvas(string fileName)
        {
            InitializeComponent();

            using (var image = Image.FromFile(fileName))
            {
                _fileName = fileName;
                _imageFormat = image.RawFormat;
                _bitmap = new Bitmap(image);
            }

            _originalBitmap = _bitmap;
            pictureBox.Image = _bitmap;
            SetClientSizeCore(_bitmap.Width, _bitmap.Height);
        }

        /// <summary>
        /// Если файл изображения существует - сохраняет изменения в файл, иначе вызывает метод SaveAs().
        /// </summary>
        public void Save()
        {
            if (_imageWasChanged)
            {
                if (_fileName == string.Empty)
                {
                    SaveAs();
                }
                else
                {
                    using (var memory = new MemoryStream())
                    {
                        _originalBitmap.Save(memory, _imageFormat);
                        var bytes = memory.ToArray();

                        using (var fileStream = new FileStream(_fileName, FileMode.Create, FileAccess.ReadWrite))
                        {
                            fileStream.Write(bytes, 0, bytes.Length);
                        }
                    }

                    _imageWasChanged = false;
                }
            }
        }

        /// <summary>
        /// Вызывает диалоговое окно для сохранения файла.
        /// </summary>
        public void SaveAs()
        {
            using (var saveDialog = new SaveFileDialog())
            {
                saveDialog.AddExtension = true;
                saveDialog.Filter = "Файл JPEG (*.jpeg)|*.jpeg|Файл PNG (*.png)|*.png|Windows Bitmap (*.bmp)|*.bmp";
                saveDialog.Title = "Сохранить текущее изображение";
                saveDialog.ShowDialog();

                var imageFormats = new ImageFormat[] { ImageFormat.Jpeg, ImageFormat.Png, ImageFormat.Bmp };
                if (saveDialog.FileName != string.Empty)
                {
                    var imageFormat = imageFormats[saveDialog.FilterIndex - 1];

                    _originalBitmap.Save(saveDialog.FileName, imageFormat);
                    _fileName = saveDialog.FileName;
                    _imageFormat = imageFormat;
                }
            }

            _imageWasChanged = false;
        }

        /// <summary>
        /// Увеличивает изображение.
        /// </summary>
        public void OnMainFormZoomInClick()
        {
            if (IsZoomMax())
            {
                return;
            }

            _zoomValue++;

            _bitmap = ZoomImage(_originalBitmap, _zoomValue); ;
            pictureBox.Image = _bitmap;
        }

        /// <summary>
        /// Уменьшает изображение.
        /// </summary>
        public void OnMainFormZoomOutClick()
        {
            if (_zoomValue == 1)
            {
                return;
            }

            _zoomValue--;

            _bitmap = ZoomImage(_originalBitmap, _zoomValue);
            pictureBox.Image = _bitmap;
        }

        public bool IsZoomed()
        {
            return _zoomValue != 1;
        }

        public bool IsZoomMax()
        {
            return _zoomValue == _maxZoomValue;
        }

        private Bitmap ZoomImage(Bitmap image, int zoomValue)
        {
            var bitmap = new Bitmap(image, (image.Width * zoomValue), (image.Height * zoomValue));

            using (var g = Graphics.FromImage(bitmap))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            }

            return bitmap;
        }

        private void OnPictureBoxMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var pen = new Pen(MainForm.CurrentColor, MainForm.CurrentPenThickness);

                switch (MainForm.CurrentTool)
                {
                    case Tool.Pen:
                        OnToolPenMouseMove(pen, e);
                        break;

                    case Tool.Line:
                        OnToolLineMouseMove(pen, e);
                        break;

                    case Tool.Rectangle:
                        OnToolRectangleMouseMove(pen, e);
                        break;

                    case Tool.Ellipse:
                        OnToolEllipseMouseMove(pen, e);
                        break;

                    case Tool.NPointedStar:
                        OnToolNPointedStarMouseMove(MainForm.CurrentStarNPoints, pen, e);
                        break;

                    case Tool.Eraser:
                        OnToolEraserMouseMove(pen, e);
                        break;

                    default:
                        break;
                }

                _imageWasChanged = true;
                pictureBox.Invalidate();
            }
        }

        private void OnPictureBoxMouseUp(object sender, MouseEventArgs e)
        {
            switch (MainForm.CurrentTool)
            {
                case Tool.Line:
                case Tool.Rectangle:
                case Tool.Ellipse:
                case Tool.NPointedStar:
                    _bitmap = _temporaryBitmap;
                    break;

                default:
                    break;
            }

            _originalBitmap = IsZoomed() ? new Bitmap(_bitmap, _originalBitmap.Width, _originalBitmap.Height) : _bitmap;
        }

        private void OnPictureBoxMouseDown(object sender, MouseEventArgs e)
        {
            _oldX = e.X;
            _oldY = e.Y;
        }

        private void OnToolPenMouseMove(Pen pen, MouseEventArgs e)
        {
            var g = Graphics.FromImage(_bitmap);
            g.DrawLine(pen, _oldX, _oldY, e.X, e.Y);

            _oldX = e.X;
            _oldY = e.Y;
        }

        private void OnToolLineMouseMove(Pen pen, MouseEventArgs e)
        {
            _temporaryBitmap = (Bitmap)_bitmap.Clone();

            var g = Graphics.FromImage(_temporaryBitmap);
            g.DrawLine(pen, _oldX, _oldY, e.X, e.Y);

            pictureBox.Image = _temporaryBitmap;
        }

        private void OnToolRectangleMouseMove(Pen pen, MouseEventArgs e)
        {
            _temporaryBitmap = (Bitmap)_bitmap.Clone();

            var g = Graphics.FromImage(_temporaryBitmap);

            if (e.X >= _oldX && e.Y < _oldY)
            {
                g.DrawRectangle(pen, new Rectangle(_oldX, e.Y, e.X - _oldX, _oldY - e.Y));
            }
            else if (e.X < _oldX && e.Y >= _oldY)
            {
                g.DrawRectangle(pen, new Rectangle(e.X, _oldY, _oldX - e.X, e.Y - _oldY));
            }
            else if (e.X >= _oldX && e.Y >= _oldY)
            {
                g.DrawRectangle(pen, new Rectangle(_oldX, _oldY, e.X - _oldX, e.Y - _oldY));
            }
            else
            {
                g.DrawRectangle(pen, new Rectangle(e.X, e.Y, _oldX - e.X, _oldY - e.Y));
            }

            pictureBox.Image = _temporaryBitmap;
        }

        private void OnToolEllipseMouseMove(Pen pen, MouseEventArgs e)
        {
            _temporaryBitmap = (Bitmap)_bitmap.Clone();

            var g = Graphics.FromImage(_temporaryBitmap);
            g.DrawEllipse(pen, new Rectangle(_oldX, _oldY, e.X - _oldX, e.Y - _oldY));
            
            pictureBox.Image = _temporaryBitmap;
        }

        private void OnToolNPointedStarMouseMove(int nPoints, Pen pen, MouseEventArgs e)
        {
            _temporaryBitmap = (Bitmap)_bitmap.Clone();
            var g = Graphics.FromImage(_temporaryBitmap);

            var externalRadius = _oldX - e.X;
            var internalRadius = (e.X - _oldX) * 0.385;
            var circleLength = (Math.PI / 180) * 360;
            var degree = circleLength / nPoints;
            var points = new List<PointF>(nPoints * 2);

            for (int i = 1, j = (nPoints / 2) + 2; i <= nPoints; i++, j++)
            {
                if (j > nPoints)
                {
                    j = 1;
                }

                points.Add(new PointF(
                    (float)(externalRadius * Math.Sin(i * degree)) + _oldX,
                    (float)(externalRadius * Math.Cos(i * degree)) + _oldY));
                points.Add(new PointF(
                    (float)(internalRadius * Math.Sin(j * degree)) + _oldX,
                    (float)(internalRadius * Math.Cos(j * degree)) + _oldY));
            }

            g.DrawPolygon(pen, points.ToArray());
            pictureBox.Image = _temporaryBitmap;
        }

        private void OnToolEraserMouseMove(Pen pen, MouseEventArgs e)
        {
            pen.Color = pictureBox.BackColor;

            var g = Graphics.FromImage(_bitmap);
            g.DrawLine(pen, _oldX, _oldY, e.X, e.Y);

            _oldX = e.X;
            _oldY = e.Y;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (_imageWasChanged)
            {
                var result = MessageBox.Show(
                    "Сохранить изменения?",
                    "Закрытие холста",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Save();
                }
            }

            _temporaryBitmap?.Dispose();
            _bitmap?.Dispose();
            _originalBitmap?.Dispose();

            base.OnFormClosing(e);
        }
    }
}