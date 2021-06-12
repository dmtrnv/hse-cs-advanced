using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using PluginInterface;
using System.Configuration;
using System.Drawing.Imaging;


namespace MainApp
{
    public partial class MainForm : Form
    {
        private readonly Dictionary<string, IPlugin> _plugins = new Dictionary<string, IPlugin>(); 
        private readonly List<string> _pluginsName = new List<string>();
        private readonly int _leftRightBorderSize;
        private readonly int _upDownBorderSize;

        public MainForm()
        {
            InitializeComponent();
            FindAndLoadPlugins();
            CreatePluginsMenu();   
            
            _leftRightBorderSize = this.Width - pictureBox.Width;
            _upDownBorderSize = this.Height - pictureBox.Height;
        }

        private void FindAndLoadPlugins()
        {
            if (ReadConfigFile())
            {
                LoadPlugins();
            }
            else
            {
                FindPlugins();
                LoadPlugins();
            }
        }

        // True - конфигурационный файл существует и успешно прочитан.
        // False - конфигурационный файл отсутствует или в нем установлен автоматический режим.
        private bool ReadConfigFile()
        {
            var configFileName = $"{Assembly.GetEntryAssembly().GetName().Name}.exe.config";
            if (!File.Exists(configFileName))
            {
                return false;
            }

            var appSettings = ConfigurationManager.AppSettings;

            if (!appSettings.HasKeys())
            {
                return true;
            }

            if (appSettings.GetKey(0) == "auto")
            {
                return false;
            }
            
            foreach (string key in appSettings)
            {
                _pluginsName.Add(appSettings[key]);
            }

            return true;
        }

        private void FindPlugins()
        {
            var temporaryAppDomain = AppDomain.CreateDomain("temporary", null);
            var folder = temporaryAppDomain.BaseDirectory;
            var files = Directory.GetFiles(folder, "*.dll");

            foreach (var file in files)
            {
                try
                {
                    var assembly = Assembly.LoadFile(file);

                    foreach (var type in assembly.GetTypes())
                    {
                        if (type.GetInterface("PluginInterface.IPlugin") != null)
                        {
                            _pluginsName.Add(assembly.ManifestModule.ToString());
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Ошибка загрузки сборки\n" + e.Message);
                }
            }

            AppDomain.Unload(temporaryAppDomain);
        }

        private void LoadPlugins()
        {
            var folder = AppDomain.CurrentDomain.BaseDirectory;

            foreach (var pluginName in _pluginsName)
            {
                try
                {
                    var assembly = Assembly.LoadFile($"{folder}\\{pluginName}");
                    
                    foreach (var type in assembly.GetTypes())
                    {
                        var pluginInterface = type.GetInterface("PluginInterface.IPlugin");

                        if (pluginInterface != null)
                        {
                            var plugin = (IPlugin)Activator.CreateInstance(type);
                            _plugins.Add(plugin.Name, plugin);
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Ошибка загрузки плагина\n" + e.Message);
                }
            }
        }

        private void CreatePluginsMenu()
        {
            foreach (var plugin in _plugins)
            {
                var item = filtersToolStripMenuItem.DropDownItems.Add(plugin.Key);
                item.Click += OnPluginClick;
            }
        }

        private void ShowMessageBoxWithLoadedPlugins()
        {
            var sb = new StringBuilder();

            foreach (var pair in _plugins)
            {
                var plugin = pair.Value;
                var version = plugin
                    .GetType()
                    .GetCustomAttribute(typeof(VersionAttribute))
                    .ToString();
                
                sb.AppendLine($"{plugin.Name} {version} {plugin.Author}");
            }

            MessageBox.Show(sb.ToString(), "Плагины подключены");
        }

        private void OnPluginClick(object sender, EventArgs args)
        {
            var plugin = _plugins[((ToolStripMenuItem)sender).Text];
            plugin.Transform((Bitmap)pictureBox.Image);
            pictureBox.Invalidate();
        }

        private void OnMainFormShown(object sender, EventArgs args)
        {
            ShowMessageBoxWithLoadedPlugins();
        }

        private void OnLoadButtonClick(object sender, EventArgs args)
        {
            using (var openDialog = new OpenFileDialog())
            {
                openDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tiff";
                openDialog.Title = "Выбрать изображение";

                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    var image = Image.FromFile(openDialog.FileName);
                    var workingArea = Screen.FromControl(this).WorkingArea;

                    if ((image.Width > (workingArea.Width + _leftRightBorderSize)) || (image.Height > (workingArea.Height + _upDownBorderSize)))
                    {
                        MessageBox.Show("Изображение имеет слишком большое разрешение.", "Ошибка!");
                        return;
                    } 
                    
                    pictureBox.Image = image;
                    menuStrip.Enabled = true;
                }
            }
        }

        private void OnSaveButtonClick(object sender, EventArgs args)
        {
            using (var saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Jpg Image|*.jpg|Png Image|*.png|Bitmap Image|*.bmp|Gif Image|*.gif|Tiff Image|*.tiff";
                saveDialog.Title = "Сохранить текущее изображение";
                saveDialog.ShowDialog();

                if (saveDialog.FileName != string.Empty)
                {
                    var imageFormats = new ImageFormat[] { ImageFormat.Jpeg, ImageFormat.Png, ImageFormat.Bmp, ImageFormat.Gif, ImageFormat.Tiff };

                    using (var fs = (FileStream)saveDialog.OpenFile())
                    {
                        pictureBox.Image.Save(fs, imageFormats[saveDialog.FilterIndex - 1]);
                    }
                }
            }
        }

        private void OnSizeChanged(object sender, EventArgs args)
        {
            var workingArea = Screen.FromControl(this).WorkingArea;

            this.Top = (workingArea.Height - this.Height) / 2;
            this.Left = (workingArea.Width - this.Width) / 2;
        }

        private void OnPictureBoxImageChanged(object sender, CustomPictureBoxEventArgs args)
        {
            this.Width = args.Width + _leftRightBorderSize;
            this.Height = args.Height + _upDownBorderSize;
        }
    }
}
