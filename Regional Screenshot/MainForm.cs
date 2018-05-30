using System;
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

		private void MainForm_MouseEnter(object sender, EventArgs e)
		{

		}

		private void MainForm_Scroll(object sender, ScrollEventArgs e)
		{
		}

		private void MainForm_MouseClick(object sender, MouseEventArgs e)
		{
		}

		// for picture format (JPG or PNG)
		private void PicFormatComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(PicFormatComboBox.SelectedItem == ".png")
			{
				label1.Visible = true;
			}
			else
			{
				label1.Visible = false;
			}
		}
	}
}
