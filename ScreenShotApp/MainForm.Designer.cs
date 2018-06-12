namespace RegionalScreenshot
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
			this.TakeSSButton = new System.Windows.Forms.Button();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.QualityLabel = new System.Windows.Forms.Label();
			this.QualityAmountLabel = new System.Windows.Forms.Label();
			this.PicFormatComboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.saveAtLabel = new System.Windows.Forms.Label();
			this.saveAtComboBox = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.SuspendLayout();
			// 
			// TakeSSButton
			// 
			this.TakeSSButton.Location = new System.Drawing.Point(12, 12);
			this.TakeSSButton.Name = "TakeSSButton";
			this.TakeSSButton.Size = new System.Drawing.Size(100, 52);
			this.TakeSSButton.TabIndex = 0;
			this.TakeSSButton.Text = "Take Screenshot";
			this.TakeSSButton.UseVisualStyleBackColor = true;
			this.TakeSSButton.Click += new System.EventHandler(this.TakeSSButton_Click);
			// 
			// trackBar1
			// 
			this.trackBar1.Location = new System.Drawing.Point(148, 30);
			this.trackBar1.Maximum = 100;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(104, 45);
			this.trackBar1.TabIndex = 1;
			this.trackBar1.Value = 100;
			this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
			// 
			// QualityLabel
			// 
			this.QualityLabel.AutoSize = true;
			this.QualityLabel.Location = new System.Drawing.Point(179, 9);
			this.QualityLabel.Name = "QualityLabel";
			this.QualityLabel.Size = new System.Drawing.Size(39, 13);
			this.QualityLabel.TabIndex = 2;
			this.QualityLabel.Text = "Quality";
			// 
			// QualityAmountLabel
			// 
			this.QualityAmountLabel.AutoSize = true;
			this.QualityAmountLabel.Location = new System.Drawing.Point(253, 32);
			this.QualityAmountLabel.Name = "QualityAmountLabel";
			this.QualityAmountLabel.Size = new System.Drawing.Size(25, 13);
			this.QualityAmountLabel.TabIndex = 3;
			this.QualityAmountLabel.Text = "100";
			// 
			// PicFormatComboBox
			// 
			this.PicFormatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.PicFormatComboBox.FormattingEnabled = true;
			this.PicFormatComboBox.Items.AddRange(new object[] {
            ".jpg",
            ".png"});
			this.PicFormatComboBox.Location = new System.Drawing.Point(12, 78);
			this.PicFormatComboBox.Name = "PicFormatComboBox";
			this.PicFormatComboBox.Size = new System.Drawing.Size(100, 21);
			this.PicFormatComboBox.TabIndex = 4;
			this.PicFormatComboBox.SelectedIndexChanged += new System.EventHandler(this.PicFormatComboBox_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(129, 79);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(149, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "(Quality not available for PNG)";
			this.label1.Visible = false;
			// 
			// saveAtLabel
			// 
			this.saveAtLabel.AutoSize = true;
			this.saveAtLabel.Location = new System.Drawing.Point(129, 116);
			this.saveAtLabel.Name = "saveAtLabel";
			this.saveAtLabel.Size = new System.Drawing.Size(49, 13);
			this.saveAtLabel.TabIndex = 6;
			this.saveAtLabel.Text = "Save @:";
			// 
			// saveAtComboBox
			// 
			this.saveAtComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.saveAtComboBox.FormattingEnabled = true;
			this.saveAtComboBox.Items.AddRange(new object[] {
            "Desktop",
            "Pictures",
            "Documents",
            "Downloads"});
			this.saveAtComboBox.Location = new System.Drawing.Point(184, 113);
			this.saveAtComboBox.Name = "saveAtComboBox";
			this.saveAtComboBox.Size = new System.Drawing.Size(90, 21);
			this.saveAtComboBox.TabIndex = 7;
			this.saveAtComboBox.SelectedIndexChanged += new System.EventHandler(this.saveAtComboBox_SelectedIndexChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(290, 150);
			this.Controls.Add(this.saveAtComboBox);
			this.Controls.Add(this.saveAtLabel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.PicFormatComboBox);
			this.Controls.Add(this.QualityAmountLabel);
			this.Controls.Add(this.QualityLabel);
			this.Controls.Add(this.trackBar1);
			this.Controls.Add(this.TakeSSButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Screenshot App";
			this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.MainForm_Scroll);
			this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
			this.MouseEnter += new System.EventHandler(this.MainForm_MouseEnter);
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button TakeSSButton;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.Label QualityLabel;
		private System.Windows.Forms.Label QualityAmountLabel;
		private System.Windows.Forms.ComboBox PicFormatComboBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label saveAtLabel;
		private System.Windows.Forms.ComboBox saveAtComboBox;
	}
}

