using System;
using System.IO;
using System.Windows.Forms;

namespace RegionalScreenshot
{
	public partial class MainForm : Form
	{
		TakeScreenShot takeScreenShot = new TakeScreenShot();

		public MainForm()
		{
			InitializeComponent();
			PicFormatComboBox.SelectedIndex = 0;
			saveAtComboBox.SelectedIndex = 0;
		}

		private void TakeSSButton_Click(object sender, EventArgs e)
		{
			PrepareScreenShotMethod();
		}

		private void PrepareScreenShotMethod()
		{
			this.Opacity = 0;
			takeScreenShot.format = PicFormatComboBox.SelectedItem.ToString();
			takeScreenShot.PutScreenshootOnScreen();
			this.Opacity = 100;
		}

		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			takeScreenShot.qualityAmount = trackBar1.Value;
			QualityAmountLabel.Text = trackBar1.Value.ToString();
		}

		// for picture format (JPG or PNG)
		private void PicFormatComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(PicFormatComboBox.SelectedItem.ToString() == ".png")
			{
				label1.Visible = true;
			}
			else
			{
				label1.Visible = false;
			}
		}

		private void saveAtComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (saveAtComboBox.SelectedItem.ToString() == "Desktop")
			{
				takeScreenShot.savePath = Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);
			}
			else if(saveAtComboBox.SelectedItem.ToString() == "Documents")
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
			else if(saveAtComboBox.SelectedItem.ToString() == "Pictures")
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
			else if(saveAtComboBox.SelectedItem.ToString() == "Other...")
			{
				FolderBrowserDialog folderDialog = new FolderBrowserDialog();

				folderDialog.ShowNewFolderButton = true;

				DialogResult result = folderDialog.ShowDialog();

				if(result == DialogResult.OK)
				{
					takeScreenShot.savePath = folderDialog.SelectedPath;
					saveAtComboBox.SelectedItem = "Other...";
				}
				else
				{
					takeScreenShot.savePath = Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);
					saveAtComboBox.SelectedItem = "Desktop";
				}
			}
		}
	}
}
