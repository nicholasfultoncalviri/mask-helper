using MaskHelper.Core;

namespace MaskHelper.WinForms
{
    public partial class Configure : Form
    {
        private bool loading = false;

        private bool Loading
        {
            get => loading;
            set
            {
                Cursor = value ? Cursors.WaitCursor : Cursors.Arrow;
                progressSpinner.Visible = value;
                selectButton.Enabled = !value;
                selectFolderButton.Enabled = !value;
                generateButton.Enabled = !value;
                loading = false;
            }
        }

        private string? filePath = null;
        private string? folderPath = null;

        public Configure()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Icon = Properties.Resources.calviri;
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog();

            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            dialog.Filter = "APF Files (*.apf)|*.apf";
            
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;
                filePathDisplay.Text = filePath;

                var fileInfo = new FileInfo(dialog.FileName);
                folderPath = fileInfo.DirectoryName;
                if (folderPath != null)
                    folderPathDisplay.Text = folderPath;
            }
        }

        private void selectFolderButton_Click(object sender, EventArgs e)
        {
            using var dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
            {
                folderPath = dialog.SelectedPath;
                folderPathDisplay.Text = folderPath;
            }
        }

        private async void generateButton_Click(object sender, EventArgs e)
        {
            if (!Loading)
            {
                Loading = true;

                if (filePath == null || folderPath == null)
                {
                    MessageBox.Show("Select a file and output folder to continue.");
                }
                else
                {
                    try
                    {
                        var fileGenerator = new FileGenerator();

                        await fileGenerator.GenerateFiles(filePath, folderPath, Convert.ToInt32(lastMaskIdInput.Value));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An unhandled exception occurred: {ex}");
                    }
                }

                Loading = false;
            }
        }
    }
}