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
                generateButton.Enabled = !value;
                loading = false;
            }
        }

        private string? filePath = null;

        public Configure()
        {
            InitializeComponent();
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
            }
        }

        private async void generateButton_Click(object sender, EventArgs e)
        {
            if (!Loading)
            {
                Loading = true;

                if (filePath == null)
                {
                    MessageBox.Show("Select a file to continue.");
                }
                else
                {
                    try
                    {
                        var fileGenerator = new FileGenerator();

                        await fileGenerator.GenerateFiles(filePath, Convert.ToInt32(lastMaskIdInput.Value));
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