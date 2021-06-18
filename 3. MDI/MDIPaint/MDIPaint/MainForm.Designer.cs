
namespace MDIPaint
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripSeparatorAfterOpen = new System.Windows.Forms.ToolStripSeparator();
            this.fileSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripSeparatorAfterSaveAs = new System.Windows.Forms.ToolStripSeparator();
            this.fileExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowCascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowLeftToRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowUpToBottomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowArrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpAboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.blackColorToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.redColorToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.greenColorToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.blueColorToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.colorPaletteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparatorAfterColorPalette = new System.Windows.Forms.ToolStripSeparator();
            this.penThicknessToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.penThicknes1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penThicknes2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penThicknes4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penThicknes8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penThicknes16ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penThicknes32ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penThicknes64ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorAfterLineThickness = new System.Windows.Forms.ToolStripSeparator();
            this.penToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.lineToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.rectangleToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ellipseToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.nPointedStarToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.nPointedStar3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nPointedStar5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nPointedStar7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nPointedStar9ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nPointedStar11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nPointedStar15ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nPointedStar21ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eraserToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparatorAfterNPointedStar = new System.Windows.Forms.ToolStripSeparator();
            this.zoomInToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.zoomOutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.pictureToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowToolStripMenuItem;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileNewToolStripMenuItem,
            this.fileOpenToolStripMenuItem,
            this.fileToolStripSeparatorAfterOpen,
            this.fileSaveToolStripMenuItem,
            this.fileSaveAsToolStripMenuItem,
            this.fileToolStripSeparatorAfterSaveAs,
            this.fileExitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "&Файл";
            this.fileToolStripMenuItem.DropDownOpening += new System.EventHandler(this.OnFileToolStripMenuItemDropDownOpening);
            // 
            // fileNewToolStripMenuItem
            // 
            this.fileNewToolStripMenuItem.Name = "fileNewToolStripMenuItem";
            this.fileNewToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.fileNewToolStripMenuItem.Text = "&Новый";
            this.fileNewToolStripMenuItem.Click += new System.EventHandler(this.OnFileNewToolStripMenuItemClick);
            // 
            // fileOpenToolStripMenuItem
            // 
            this.fileOpenToolStripMenuItem.Name = "fileOpenToolStripMenuItem";
            this.fileOpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.fileOpenToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.fileOpenToolStripMenuItem.Text = "О&ткрыть...";
            this.fileOpenToolStripMenuItem.Click += new System.EventHandler(this.OnFileOpenToolStripMenuItemClick);
            // 
            // fileToolStripSeparatorAfterOpen
            // 
            this.fileToolStripSeparatorAfterOpen.Name = "fileToolStripSeparatorAfterOpen";
            this.fileToolStripSeparatorAfterOpen.Size = new System.Drawing.Size(170, 6);
            // 
            // fileSaveToolStripMenuItem
            // 
            this.fileSaveToolStripMenuItem.Name = "fileSaveToolStripMenuItem";
            this.fileSaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.fileSaveToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.fileSaveToolStripMenuItem.Text = "Сохранить";
            this.fileSaveToolStripMenuItem.Click += new System.EventHandler(this.OnFileSaveToolStripMenuItemClick);
            // 
            // fileSaveAsToolStripMenuItem
            // 
            this.fileSaveAsToolStripMenuItem.Name = "fileSaveAsToolStripMenuItem";
            this.fileSaveAsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.fileSaveAsToolStripMenuItem.Text = "Со&хранить как...";
            this.fileSaveAsToolStripMenuItem.Click += new System.EventHandler(this.OnFileSaveAsToolStripMenuItemClick);
            // 
            // fileToolStripSeparatorAfterSaveAs
            // 
            this.fileToolStripSeparatorAfterSaveAs.Name = "fileToolStripSeparatorAfterSaveAs";
            this.fileToolStripSeparatorAfterSaveAs.Size = new System.Drawing.Size(170, 6);
            // 
            // fileExitToolStripMenuItem
            // 
            this.fileExitToolStripMenuItem.Name = "fileExitToolStripMenuItem";
            this.fileExitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.fileExitToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.fileExitToolStripMenuItem.Text = "Выход";
            this.fileExitToolStripMenuItem.Click += new System.EventHandler(this.OnFileExitToolStripMenuItemClick);
            // 
            // pictureToolStripMenuItem
            // 
            this.pictureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pictureSizeToolStripMenuItem});
            this.pictureToolStripMenuItem.Name = "pictureToolStripMenuItem";
            this.pictureToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.pictureToolStripMenuItem.Text = "&Рисунок";
            this.pictureToolStripMenuItem.DropDownOpening += new System.EventHandler(this.OnPictureToolStripMenuItemDropDownOpening);
            // 
            // pictureSizeToolStripMenuItem
            // 
            this.pictureSizeToolStripMenuItem.Name = "pictureSizeToolStripMenuItem";
            this.pictureSizeToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.pictureSizeToolStripMenuItem.Text = "Р&азмер холста...";
            this.pictureSizeToolStripMenuItem.Click += new System.EventHandler(this.OnPictureSizeToolStripMenuItemClick);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowCascadeToolStripMenuItem,
            this.windowLeftToRightToolStripMenuItem,
            this.windowUpToBottomToolStripMenuItem,
            this.windowArrangeIconsToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.windowToolStripMenuItem.Text = "&Окно";
            // 
            // windowCascadeToolStripMenuItem
            // 
            this.windowCascadeToolStripMenuItem.Name = "windowCascadeToolStripMenuItem";
            this.windowCascadeToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.windowCascadeToolStripMenuItem.Text = "&Каскадом";
            this.windowCascadeToolStripMenuItem.Click += new System.EventHandler(this.OnWindowCascadeToolStripMenuItemClick);
            // 
            // windowLeftToRightToolStripMenuItem
            // 
            this.windowLeftToRightToolStripMenuItem.Name = "windowLeftToRightToolStripMenuItem";
            this.windowLeftToRightToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.windowLeftToRightToolStripMenuItem.Text = "Слева напр&аво";
            this.windowLeftToRightToolStripMenuItem.Click += new System.EventHandler(this.OnWindowLeftToRightToolStripMenuItemClick);
            // 
            // windowUpToBottomToolStripMenuItem
            // 
            this.windowUpToBottomToolStripMenuItem.Name = "windowUpToBottomToolStripMenuItem";
            this.windowUpToBottomToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.windowUpToBottomToolStripMenuItem.Text = "Сверху вн&из";
            this.windowUpToBottomToolStripMenuItem.Click += new System.EventHandler(this.OnWindowUpToBottomToolStripMenuItemClick);
            // 
            // windowArrangeIconsToolStripMenuItem
            // 
            this.windowArrangeIconsToolStripMenuItem.Name = "windowArrangeIconsToolStripMenuItem";
            this.windowArrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.windowArrangeIconsToolStripMenuItem.Text = "&Упорядочить значки";
            this.windowArrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.OnWindowArrangeIconsToolStripMenuItemClick);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpAboutProgramToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.helpToolStripMenuItem.Text = "&Справка";
            // 
            // helpAboutProgramToolStripMenuItem
            // 
            this.helpAboutProgramToolStripMenuItem.Name = "helpAboutProgramToolStripMenuItem";
            this.helpAboutProgramToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.helpAboutProgramToolStripMenuItem.Text = "О &программе...";
            this.helpAboutProgramToolStripMenuItem.Click += new System.EventHandler(this.OnHelpAboutProgramToolStripMenuItemClick);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blackColorToolStripButton,
            this.redColorToolStripButton,
            this.greenColorToolStripButton,
            this.blueColorToolStripButton,
            this.colorPaletteToolStripButton,
            this.toolStripSeparatorAfterColorPalette,
            this.penThicknessToolStripDropDownButton,
            this.toolStripSeparatorAfterLineThickness,
            this.penToolStripButton,
            this.lineToolStripButton,
            this.rectangleToolStripButton,
            this.ellipseToolStripButton,
            this.nPointedStarToolStripDropDownButton,
            this.eraserToolStripButton,
            this.toolStripSeparatorAfterNPointedStar,
            this.zoomInToolStripButton,
            this.zoomOutToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(800, 25);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip";
            this.toolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OnToolStripItemClicked);
            // 
            // blackColorToolStripButton
            // 
            this.blackColorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.blackColorToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("blackColorToolStripButton.Image")));
            this.blackColorToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.blackColorToolStripButton.Name = "blackColorToolStripButton";
            this.blackColorToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.blackColorToolStripButton.Text = "blackColorToolStripButton";
            this.blackColorToolStripButton.ToolTipText = "Черный";
            this.blackColorToolStripButton.Click += new System.EventHandler(this.OnBlackColorToolStripButtonClick);
            // 
            // redColorToolStripButton
            // 
            this.redColorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.redColorToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("redColorToolStripButton.Image")));
            this.redColorToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.redColorToolStripButton.Name = "redColorToolStripButton";
            this.redColorToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.redColorToolStripButton.Text = "redColorToolStripButton";
            this.redColorToolStripButton.ToolTipText = "Красный";
            this.redColorToolStripButton.Click += new System.EventHandler(this.OnRedColorToolStripButtonClick);
            // 
            // greenColorToolStripButton
            // 
            this.greenColorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.greenColorToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("greenColorToolStripButton.Image")));
            this.greenColorToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.greenColorToolStripButton.Name = "greenColorToolStripButton";
            this.greenColorToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.greenColorToolStripButton.Text = "greenColorToolStripButton";
            this.greenColorToolStripButton.ToolTipText = "Зеленый";
            this.greenColorToolStripButton.Click += new System.EventHandler(this.OnGreenColorToolStripButtonClick);
            // 
            // blueColorToolStripButton
            // 
            this.blueColorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.blueColorToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("blueColorToolStripButton.Image")));
            this.blueColorToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.blueColorToolStripButton.Name = "blueColorToolStripButton";
            this.blueColorToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.blueColorToolStripButton.Text = "blueColorToolStripButton";
            this.blueColorToolStripButton.ToolTipText = "Синий";
            this.blueColorToolStripButton.Click += new System.EventHandler(this.OnBlueColorToolStripButtonClick);
            // 
            // colorPaletteToolStripButton
            // 
            this.colorPaletteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colorPaletteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("colorPaletteToolStripButton.Image")));
            this.colorPaletteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colorPaletteToolStripButton.Name = "colorPaletteToolStripButton";
            this.colorPaletteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.colorPaletteToolStripButton.Text = "colorPaletteToolStripButton";
            this.colorPaletteToolStripButton.ToolTipText = "Выбрать цвет...";
            this.colorPaletteToolStripButton.Click += new System.EventHandler(this.OnColorPalletteToolStripButtonClick);
            // 
            // toolStripSeparatorAfterColorPalette
            // 
            this.toolStripSeparatorAfterColorPalette.Name = "toolStripSeparatorAfterColorPalette";
            this.toolStripSeparatorAfterColorPalette.Size = new System.Drawing.Size(6, 25);
            // 
            // penThicknessToolStripDropDownButton
            // 
            this.penThicknessToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.penThicknessToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.penThicknes1ToolStripMenuItem,
            this.penThicknes2ToolStripMenuItem,
            this.penThicknes4ToolStripMenuItem,
            this.penThicknes8ToolStripMenuItem,
            this.penThicknes16ToolStripMenuItem,
            this.penThicknes32ToolStripMenuItem,
            this.penThicknes64ToolStripMenuItem});
            this.penThicknessToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("penThicknessToolStripDropDownButton.Image")));
            this.penThicknessToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.penThicknessToolStripDropDownButton.Name = "penThicknessToolStripDropDownButton";
            this.penThicknessToolStripDropDownButton.Size = new System.Drawing.Size(29, 22);
            this.penThicknessToolStripDropDownButton.Text = "penThicknessToolStripDropDownButton";
            this.penThicknessToolStripDropDownButton.ToolTipText = "Выбрать толщину пера...";
            this.penThicknessToolStripDropDownButton.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OnPenThicknessToolStripDropDownButtonDropDownItemClicked);
            // 
            // penThicknes1ToolStripMenuItem
            // 
            this.penThicknes1ToolStripMenuItem.Name = "penThicknes1ToolStripMenuItem";
            this.penThicknes1ToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.penThicknes1ToolStripMenuItem.Text = "1";
            // 
            // penThicknes2ToolStripMenuItem
            // 
            this.penThicknes2ToolStripMenuItem.Name = "penThicknes2ToolStripMenuItem";
            this.penThicknes2ToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.penThicknes2ToolStripMenuItem.Text = "2";
            // 
            // penThicknes4ToolStripMenuItem
            // 
            this.penThicknes4ToolStripMenuItem.Name = "penThicknes4ToolStripMenuItem";
            this.penThicknes4ToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.penThicknes4ToolStripMenuItem.Text = "4";
            // 
            // penThicknes8ToolStripMenuItem
            // 
            this.penThicknes8ToolStripMenuItem.Name = "penThicknes8ToolStripMenuItem";
            this.penThicknes8ToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.penThicknes8ToolStripMenuItem.Text = "8";
            // 
            // penThicknes16ToolStripMenuItem
            // 
            this.penThicknes16ToolStripMenuItem.Name = "penThicknes16ToolStripMenuItem";
            this.penThicknes16ToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.penThicknes16ToolStripMenuItem.Text = "16";
            // 
            // penThicknes32ToolStripMenuItem
            // 
            this.penThicknes32ToolStripMenuItem.Name = "penThicknes32ToolStripMenuItem";
            this.penThicknes32ToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.penThicknes32ToolStripMenuItem.Text = "32";
            // 
            // penThicknes64ToolStripMenuItem
            // 
            this.penThicknes64ToolStripMenuItem.Name = "penThicknes64ToolStripMenuItem";
            this.penThicknes64ToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.penThicknes64ToolStripMenuItem.Text = "64";
            // 
            // toolStripSeparatorAfterLineThickness
            // 
            this.toolStripSeparatorAfterLineThickness.Name = "toolStripSeparatorAfterLineThickness";
            this.toolStripSeparatorAfterLineThickness.Size = new System.Drawing.Size(6, 25);
            // 
            // penToolStripButton
            // 
            this.penToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.penToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("penToolStripButton.Image")));
            this.penToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.penToolStripButton.Name = "penToolStripButton";
            this.penToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.penToolStripButton.Text = "penToolStripButton";
            this.penToolStripButton.ToolTipText = "Перо";
            this.penToolStripButton.Click += new System.EventHandler(this.OnPenToolStripButtonClick);
            // 
            // lineToolStripButton
            // 
            this.lineToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lineToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("lineToolStripButton.Image")));
            this.lineToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lineToolStripButton.Name = "lineToolStripButton";
            this.lineToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.lineToolStripButton.Text = "lineToolStripButton";
            this.lineToolStripButton.ToolTipText = "Линия";
            this.lineToolStripButton.Click += new System.EventHandler(this.OnLineToolStripButtonClick);
            // 
            // rectangleToolStripButton
            // 
            this.rectangleToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rectangleToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("rectangleToolStripButton.Image")));
            this.rectangleToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rectangleToolStripButton.Name = "rectangleToolStripButton";
            this.rectangleToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.rectangleToolStripButton.Text = "rectangleToolStripButton";
            this.rectangleToolStripButton.ToolTipText = "Прямоугольник";
            this.rectangleToolStripButton.Click += new System.EventHandler(this.OnRectangleToolStripButtonClick);
            // 
            // ellipseToolStripButton
            // 
            this.ellipseToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ellipseToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ellipseToolStripButton.Image")));
            this.ellipseToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ellipseToolStripButton.Name = "ellipseToolStripButton";
            this.ellipseToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ellipseToolStripButton.Text = "ellipseToolStripButton";
            this.ellipseToolStripButton.ToolTipText = "Эллипс";
            this.ellipseToolStripButton.Click += new System.EventHandler(this.OnEllipseToolStripButtonClick);
            // 
            // nPointedStarToolStripDropDownButton
            // 
            this.nPointedStarToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nPointedStarToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nPointedStar3ToolStripMenuItem,
            this.nPointedStar5ToolStripMenuItem,
            this.nPointedStar7ToolStripMenuItem,
            this.nPointedStar9ToolStripMenuItem,
            this.nPointedStar11ToolStripMenuItem,
            this.nPointedStar15ToolStripMenuItem,
            this.nPointedStar21ToolStripMenuItem});
            this.nPointedStarToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("nPointedStarToolStripDropDownButton.Image")));
            this.nPointedStarToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nPointedStarToolStripDropDownButton.Name = "nPointedStarToolStripDropDownButton";
            this.nPointedStarToolStripDropDownButton.Size = new System.Drawing.Size(29, 22);
            this.nPointedStarToolStripDropDownButton.Text = "nPointedStarToolStripDropDownButton";
            this.nPointedStarToolStripDropDownButton.ToolTipText = "N-конечная звезда...";
            this.nPointedStarToolStripDropDownButton.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OnNPointedStarToolStripDropDownButtonDropDownItemClicked);
            // 
            // nPointedStar3ToolStripMenuItem
            // 
            this.nPointedStar3ToolStripMenuItem.Name = "nPointedStar3ToolStripMenuItem";
            this.nPointedStar3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nPointedStar3ToolStripMenuItem.Text = "3";
            // 
            // nPointedStar5ToolStripMenuItem
            // 
            this.nPointedStar5ToolStripMenuItem.Name = "nPointedStar5ToolStripMenuItem";
            this.nPointedStar5ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nPointedStar5ToolStripMenuItem.Text = "5";
            // 
            // nPointedStar7ToolStripMenuItem
            // 
            this.nPointedStar7ToolStripMenuItem.Name = "nPointedStar7ToolStripMenuItem";
            this.nPointedStar7ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nPointedStar7ToolStripMenuItem.Text = "7";
            // 
            // nPointedStar9ToolStripMenuItem
            // 
            this.nPointedStar9ToolStripMenuItem.Name = "nPointedStar9ToolStripMenuItem";
            this.nPointedStar9ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nPointedStar9ToolStripMenuItem.Text = "9";
            // 
            // nPointedStar11ToolStripMenuItem
            // 
            this.nPointedStar11ToolStripMenuItem.Name = "nPointedStar11ToolStripMenuItem";
            this.nPointedStar11ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nPointedStar11ToolStripMenuItem.Text = "11";
            // 
            // nPointedStar15ToolStripMenuItem
            // 
            this.nPointedStar15ToolStripMenuItem.Name = "nPointedStar15ToolStripMenuItem";
            this.nPointedStar15ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nPointedStar15ToolStripMenuItem.Text = "15";
            // 
            // nPointedStar21ToolStripMenuItem
            // 
            this.nPointedStar21ToolStripMenuItem.Name = "nPointedStar21ToolStripMenuItem";
            this.nPointedStar21ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nPointedStar21ToolStripMenuItem.Text = "21";
            // 
            // eraserToolStripButton
            // 
            this.eraserToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eraserToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("eraserToolStripButton.Image")));
            this.eraserToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.eraserToolStripButton.Name = "eraserToolStripButton";
            this.eraserToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.eraserToolStripButton.Text = "eraserToolStripButton";
            this.eraserToolStripButton.ToolTipText = "Ластик";
            this.eraserToolStripButton.Click += new System.EventHandler(this.OnEraserToolStripButtonClick);
            // 
            // toolStripSeparatorAfterNPointedStar
            // 
            this.toolStripSeparatorAfterNPointedStar.Name = "toolStripSeparatorAfterNPointedStar";
            this.toolStripSeparatorAfterNPointedStar.Size = new System.Drawing.Size(6, 25);
            // 
            // zoomInToolStripButton
            // 
            this.zoomInToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomInToolStripButton.Enabled = false;
            this.zoomInToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("zoomInToolStripButton.Image")));
            this.zoomInToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomInToolStripButton.Name = "zoomInToolStripButton";
            this.zoomInToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.zoomInToolStripButton.Text = "zoomInToolStripButton";
            this.zoomInToolStripButton.ToolTipText = "Увеличить масштаб";
            this.zoomInToolStripButton.Click += new System.EventHandler(this.OnZoomInToolStripButtonClick);
            // 
            // zoomOutToolStripButton
            // 
            this.zoomOutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomOutToolStripButton.Enabled = false;
            this.zoomOutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("zoomOutToolStripButton.Image")));
            this.zoomOutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomOutToolStripButton.Name = "zoomOutToolStripButton";
            this.zoomOutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.zoomOutToolStripButton.Text = "zoomOutToolStripButton";
            this.zoomOutToolStripButton.ToolTipText = "Уменьшить масштаб";
            this.zoomOutToolStripButton.Click += new System.EventHandler(this.OnZoomOutToolStripButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мой Paint";
            this.MdiChildActivate += new System.EventHandler(this.OnMainFormMdiChildActivate);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileOpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator fileToolStripSeparatorAfterOpen;
        private System.Windows.Forms.ToolStripMenuItem fileSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileSaveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator fileToolStripSeparatorAfterSaveAs;
        private System.Windows.Forms.ToolStripMenuItem fileExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pictureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pictureSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowCascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowLeftToRightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowUpToBottomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowArrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpAboutProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton blackColorToolStripButton;
        private System.Windows.Forms.ToolStripButton redColorToolStripButton;
        private System.Windows.Forms.ToolStripButton greenColorToolStripButton;
        private System.Windows.Forms.ToolStripButton blueColorToolStripButton;
        private System.Windows.Forms.ToolStripButton colorPaletteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorAfterColorPalette;
        private System.Windows.Forms.ToolStripDropDownButton penThicknessToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem penThicknes1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penThicknes2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penThicknes4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penThicknes8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penThicknes16ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorAfterLineThickness;
        private System.Windows.Forms.ToolStripButton penToolStripButton;
        private System.Windows.Forms.ToolStripButton lineToolStripButton;
        private System.Windows.Forms.ToolStripButton rectangleToolStripButton;
        private System.Windows.Forms.ToolStripButton ellipseToolStripButton;
        private System.Windows.Forms.ToolStripButton eraserToolStripButton;
        private System.Windows.Forms.ToolStripDropDownButton nPointedStarToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem nPointedStar3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nPointedStar5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nPointedStar7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nPointedStar9ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nPointedStar11ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorAfterNPointedStar;
        private System.Windows.Forms.ToolStripButton zoomInToolStripButton;
        private System.Windows.Forms.ToolStripButton zoomOutToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem penThicknes32ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penThicknes64ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nPointedStar15ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nPointedStar21ToolStripMenuItem;
    }
}

