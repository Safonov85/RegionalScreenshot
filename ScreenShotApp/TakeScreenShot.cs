using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Diagnostics;
using Microsoft.Win32;

namespace RegionalScreenshot
{
	public class TakeScreenShot
	{
		public Int64 qualityAmount = 100L;
		Form form;
		bool ctrlDown = false;
		public int cursorSizeX, cursorSizeY;
		PictureBox pictureBox = new PictureBox();
		public string format = ".jpg";
		string manualTutorial = "Scroll (+ Hold Ctrl) ( ← → ↑ ↓ )";
		public string savePath;

        int width_4K = 3840;
        int height_4K = 2160;

		public TakeScreenShot()
		{
			cursorSizeX = 400;
			cursorSizeY = 400;
			form = new Form();
			form.MouseWheel += new MouseEventHandler(form_MouseWheel);
			form.KeyDown += new KeyEventHandler(form_KeyDown);
			form.Click += new System.EventHandler(form_Click);
			form.KeyUp += new KeyEventHandler(form_KeyUp);
			form.KeyPreview = true;
			savePath = Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);

			// pictureBox CLICK WORKING!!!!!!!!!!
			pictureBox.Click += new EventHandler(picturebox_Click);
			//pictureBox.
		}

		private void picturebox_Click(object sender, EventArgs e)
		{
			MouseEventArgs me = (MouseEventArgs)e;
			if (me.Button == MouseButtons.Left)
			{
				TakeCurrentScreenshoot(Control.MousePosition.X, Control.MousePosition.Y, format, qualityAmount);
				form.Close();
				return;
			}
			if (me.Button == MouseButtons.Right)
			{
				form.Close();
			}
		}

        void AppleConvert()
        {
            // possible work around for Apple products/device
        }

		private void form_KeyUp(object sender, KeyEventArgs e)
		{
			// CTRL Down
			if (e.KeyCode == Keys.ControlKey)
			{
				ctrlDown = false;
                manualTutorial = "Scroll ← →";
                form.Cursor = CreateCursor(cursorSizeX, cursorSizeY);
            }

			// Esc press EXIST!!!
			if (e.KeyCode == Keys.Escape)
			{
				//SaveGraphics();
				form.Close();
			}
		}

		private void form_Click(object sender, EventArgs e)
		{
			form.Close();
		}

		private void form_KeyDown(object sender, KeyEventArgs e)
		{
            CursorSizeChange(e);
        }

        private void CursorSizeChange(KeyEventArgs e)
        {
            if (e.Control)
            {
                ctrlDown = true;
                manualTutorial = "Scroll + Hold Ctrl ↑ ↓";
                form.Cursor = CreateCursor(cursorSizeX, cursorSizeY);
            }
            if (e.KeyData == Keys.Up)
            {
                cursorSizeY += 20;
                form.Cursor = CreateCursor(cursorSizeX, cursorSizeY);
            }
            if (e.KeyData == Keys.Down)
            {
                cursorSizeY -= 20;
                if (cursorSizeY < 20)
                {
                    cursorSizeY = 20;
                }
                form.Cursor = CreateCursor(cursorSizeX, cursorSizeY);
            }
            if (e.KeyData == Keys.Right)
            {
                cursorSizeX -= 20;
                if (cursorSizeX < 20)
                {
                    cursorSizeX = 20;
                }
                form.Cursor = CreateCursor(cursorSizeX, cursorSizeY);
            }
            if (e.KeyData == Keys.Left)
            {
                cursorSizeX += 20;
                form.Cursor = CreateCursor(cursorSizeX, cursorSizeY);
            }
        }

		// WORKING !!!!!!!!!!!!!!!!!
		private void form_MouseWheel(object sender, MouseEventArgs e)
		{
			//manualTutorial = "Scroll + Ctrl";
			if (e.Delta == 120)
			{
				if (ctrlDown == false)
				{
					cursorSizeX += 20;
					form.Cursor = CreateCursor(cursorSizeX, cursorSizeY);
					// rectangle expand
				}
				else
				{
					cursorSizeY += 20;
					form.Cursor = CreateCursor(cursorSizeX, cursorSizeY);
				}
			}
			else
			{
				if (ctrlDown == false)
				{
					cursorSizeX -= 20;
					if (cursorSizeX < 20)
					{
						cursorSizeX = 20;
					}
					form.Cursor = CreateCursor(cursorSizeX, cursorSizeY);
					// rectangle expand
				}
				else
				{
					cursorSizeY -= 20;
					if (cursorSizeY < 20)
					{
						cursorSizeY = 20;
					}
					form.Cursor = CreateCursor(cursorSizeX, cursorSizeY);
				}
			}
		}

		public void TakeCurrentScreenshoot(int cursorPosX, int cursorPosY, string format, Int64 quality)
		{
			Bitmap screen = new Bitmap(cursorSizeX, cursorSizeY);
			Graphics graphics = Graphics.FromImage(screen);

			float screenStartX = cursorPosX - (screen.Size.Width / 2);
			float screenStartY = cursorPosY - (screen.Size.Height / 2);

			// Crops the Exact Region
			graphics.CopyFromScreen((int)screenStartX, (int)screenStartY, 0, 0, screen.Size);
			
			if (format == ".jpg")
			{
				ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);
				System.Drawing.Imaging.Encoder myEncoder =
					System.Drawing.Imaging.Encoder.Quality;
				EncoderParameters myEncoderParameters = new EncoderParameters(1);

				EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, qualityAmount);
				myEncoderParameters.Param[0] = myEncoderParameter;

                screen.Save(savePath + "\\" + DateTime.Now.ToString("yyyyMMdd") + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() +
                	DateTime.Now.Second.ToString() + "Quality_" + quality.ToString() + format, jpgEncoder, myEncoderParameters);
            }
            else if (format == ".png")
			{
                screen.Save(savePath + "\\" + DateTime.Now.ToString("yyyyMMdd") + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() +
                	DateTime.Now.Second.ToString() + format, ImageFormat.Png);
            }
        }

		public void PutScreenshootOnScreen()
		{
            Bitmap screen;
            if (Screen.PrimaryScreen.Bounds.Height > 1080)
            {
                screen = new Bitmap(width_4K, height_4K);
            }
            else
            {
                screen = new Bitmap(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width,
                             System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height);
            }
			
			Graphics graphics = Graphics.FromImage(screen);

            //int currentDPI = (int)Registry.GetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "LogPixels", 96);

            //float scaleBy = 96 / currentDPI;

            //int whateva = SystemInformation.VirtualScreen.X;

            //int whateva2 = SystemInformation.WorkingArea.Size.Width;

            //using (Graphics graphics1 = Graphics.FromHwnd(IntPtr.Zero))
            //{
            //    float dpiX = graphics1.DpiX;
            //    float dpiY = graphics1.DpiY;
            //    int wut = 0;
            //}

            graphics.CopyFromScreen(SystemInformation.VirtualScreen.X,
							 SystemInformation.VirtualScreen.Y,
							 0, 0, screen.Size);
			string desktopPath = Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);


			ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);
			System.Drawing.Imaging.Encoder myEncoder =
				System.Drawing.Imaging.Encoder.Quality;
			EncoderParameters myEncoderParameters = new EncoderParameters(1);

			EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, qualityAmount);
			myEncoderParameters.Param[0] = myEncoderParameter;
			CreateNewScreen(screen);
			graphics.Dispose();
		}

		void TakeScreenshotLive()
		{
			// Taking a screenshot without putting it on screen first,
			// just snapping a pic while things are moving on the screen
		}

		private ImageCodecInfo GetEncoder(ImageFormat format)
		{
			ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
			foreach (ImageCodecInfo codec in codecs)
			{
				if (codec.FormatID == format.Guid)
				{
					return codec;
				}
			}
			return null;
		}

		// creates new dialog with captured screen picture to choose region from
		void CreateNewScreen(Image picture)
		{
			form.Text = "Screenshot Viewer";

			pictureBox.Image = picture;
			pictureBox.Dock = DockStyle.Fill;
			form.Controls.Add(pictureBox);
			form.Cursor = CreateCursor(cursorSizeX, cursorSizeY);
			Debug.WriteLine(DateTime.Now.Second.ToString());
			form.FormBorderStyle = FormBorderStyle.None;
			form.WindowState = FormWindowState.Maximized;
			form.ShowDialog();
		}

		// Test
		void SaveGraphics()
		{
			Bitmap image = new Bitmap(100, 100);
			Graphics graphics = Graphics.FromImage(image);


			Pen pen = new Pen(Color.Red, 1);
			pen.DashPattern = new float[] { 2.0F, 2.0F, 2.0F, 2.0F };
			Point myPoint1 = new Point(10, 20);
			Point myPoint2 = new Point(30, 40);
			graphics.DrawRectangle(pen, 0, 0, 99, 99);


			image.Save("testing01.bmp");
			image.Dispose();
			graphics.Dispose();
		}

        // Obvious
		Cursor CreateCursor(int x, int y)
		{
			Bitmap image = new Bitmap(x, y);
			Graphics graphics = Graphics.FromImage(image);

			Pen pen = new Pen(Color.Red, 2);
			pen.DashPattern = new float[] { 2.0F, 2.0F, 2.0F, 2.0F };
			Point myPoint1 = new Point(10, 20);
			Point myPoint2 = new Point(30, 40);
			graphics.DrawRectangle(pen, 0, 0, x - 1, y - 1);

			// blue circle
			//graphics.DrawEllipse(Pens.Blue, 0, 0, 50, 50);

			// Text
			graphics.DrawString(manualTutorial, new Font("Calibri", 20, FontStyle.Regular), Brushes.Black, 0, y - 50);
			//image.Save("cursor.bmp");

			return new Cursor(image.GetHicon());
		}
	}
}
