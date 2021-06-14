using System;
using System.Windows.Forms;


namespace LabControls
{
    public partial class FilePathSelect : UserControl
    {
        public string FileName
        {
            get => txtPath.Text;

            set => txtPath.Text = value;
        }

        public FilePathSelect()
        {
            InitializeComponent();
        }

        private void OnBtnSelectPathClick(object sender, EventArgs e)
        {
            using (var fileDialog = new OpenFileDialog())
            {
                fileDialog.Title = "Выберите файл";
                fileDialog.FileName = FileName;

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileName = fileDialog.FileName;
                }
            }
        }
    }
}
