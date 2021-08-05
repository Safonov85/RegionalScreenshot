using System;
using System.IO;
using System.Windows.Forms;

namespace RegionalScreenshot
{

        // ATM, app only works for max res 1080p properly
	// Need to make proper settings for 4K beta version

	public partial class MainForm : Form
	{
        // Variables
		TakeScreenShot takeScreenShot = new TakeScreenShot();
        public int whateva = 345;

		public MainForm()
		{
            
            InitializeComponent();
			PicFormatComboBox.SelectedIndex = 0;
			saveAtComboBox.SelectedIndex = 1;
            //MainForm.DefaultBackColor = Color
            UpdatePixelSizeInfo();

            CreateSavePath("");

        }


        // Methods
        private void TakeSSButton_Click(object sender, EventArgs e)
		{
			PrepareScreenShotMethod();
		}

		private void PrepareScreenShotMethod()
		{
			this.Opacity = 0;
			takeScreenShot.format = PicFormatComboBox.SelectedItem.ToString();
			takeScreenShot.PutScreenshootOnScreen();
            UpdatePixelSizeInfo();
            this.Opacity = 100;
		}

        private void UpdatePixelSizeInfo()
        {
            CurrentSizeLabel.Text = "Current Size X: " + takeScreenShot.cursorSizeX.ToString() + " Y: " + takeScreenShot.cursorSizeY.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
		{
			takeScreenShot.qualityAmount = trackBar1.Value;
			QualityAmountLabel.Text = trackBar1.Value.ToString();
		}

		// for picture format (JPG or PNG)
		private void PicFormatComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
            PictureFormatSelections();
        }

        private void saveAtComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
            ChooseSaveSelections();
		}

        void PictureFormatSelections()
        {
            if (PicFormatComboBox.SelectedItem.ToString() == ".png")
            {
                label1.Visible = true;
                trackBar1.Visible = false;
                QualityAmountLabel.Visible = false;
                QualityLabel.Visible = false;
            }
            else
            {
                label1.Visible = false;
                trackBar1.Visible = true;
                QualityAmountLabel.Visible = true;
                QualityLabel.Visible = true;
            }
        }

        private void ChooseSaveSelections()
        {
            if (saveAtComboBox.SelectedItem.ToString() == "Desktop")
            {
                takeScreenShot.savePath = Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);
            }
            else if (saveAtComboBox.SelectedItem.ToString() == "Documents")
            {
                if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)))
                {
                    takeScreenShot.savePath = Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
                }
                else
                {
                    MessageBox.Show("Documents or My Documents folder doesn't exist");
                    takeScreenShot.savePath = Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);
                    saveAtComboBox.SelectedItem = "Desktop";
                }
            }
            else if (saveAtComboBox.SelectedItem.ToString() == "Pictures")
            {
                if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)))
                {
                    takeScreenShot.savePath = Environment.GetFolderPath(System.Environment.SpecialFolder.MyPictures);
                }
                else
                {
                    MessageBox.Show("Pictures or My Pictures folder doesn't exist");
                    takeScreenShot.savePath = Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);
                    saveAtComboBox.SelectedItem = "Desktop";
                }
            }
            else if (saveAtComboBox.SelectedItem.ToString() == "Downloads")
            {
                if (false)
                {
                    // nuffin

                }
                else
                {
                    MessageBox.Show("Downloads currently unavaliable");
                    takeScreenShot.savePath = Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);
                    saveAtComboBox.SelectedItem = "Desktop";
                }
            }
            else if (saveAtComboBox.SelectedItem.ToString() == "Other...")
            {
                FolderBrowserDialog folderDialog = new FolderBrowserDialog();

                folderDialog.ShowNewFolderButton = true;

                DialogResult result = folderDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    takeScreenShot.savePath = folderDialog.SelectedPath;
                    CreateSavePath(folderDialog.SelectedPath);
                    saveAtComboBox.SelectedItem = "Other...";
                }
                else
                {
                    takeScreenShot.savePath = Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);
                    saveAtComboBox.SelectedItem = "Desktop";
                }
            }
        }

        void CreateSavePath(string path)
        {
            //string[] lines = { "First line", "Second line", "Third line" };
            if(path == "")
            {
                path = "\\pathfolder";
            }

            // Set a variable to the Documents path.
            string docPath = "";
              

            // Write the string array to a new file named "WriteLines.txt".
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "pathSaveFolder.txt")))
            {
                    outputFile.WriteLine(path);
            }
        }

        private void Screen4K_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Screen4K_CheckBox.Checked)
            {
                takeScreenShot.Screen4kCheck = true;
            }
            else
            {
                takeScreenShot.Screen4kCheck = false;
            }
        }
    }
}
