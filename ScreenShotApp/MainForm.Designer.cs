namespace RegionalScreenshot
{
	public partial class MainForm
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
            this.CurrentSizeLabel = new System.Windows.Forms.Label();
            this.Screen4K_CheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // TakeSSButton
            // 
            this.TakeSSButton.Location = new System.Drawing.Point(18, 18);
            this.TakeSSButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TakeSSButton.Name = "TakeSSButton";
            this.TakeSSButton.Size = new System.Drawing.Size(150, 80);
            this.TakeSSButton.TabIndex = 0;
            this.TakeSSButton.Text = "Take Screenshot";
            this.TakeSSButton.UseVisualStyleBackColor = true;
            this.TakeSSButton.Click += new System.EventHandler(this.TakeSSButton_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(222, 46);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(156, 69);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // QualityLabel
            // 
            this.QualityLabel.AutoSize = true;
            this.QualityLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.QualityLabel.Location = new System.Drawing.Point(268, 14);
            this.QualityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QualityLabel.Name = "QualityLabel";
            this.QualityLabel.Size = new System.Drawing.Size(57, 20);
            this.QualityLabel.TabIndex = 2;
            this.QualityLabel.Text = "Quality";
            // 
            // QualityAmountLabel
            // 
            this.QualityAmountLabel.AutoSize = true;
            this.QualityAmountLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.QualityAmountLabel.Location = new System.Drawing.Point(380, 49);
            this.QualityAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QualityAmountLabel.Name = "QualityAmountLabel";
            this.QualityAmountLabel.Size = new System.Drawing.Size(36, 20);
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
            this.PicFormatComboBox.Location = new System.Drawing.Point(18, 120);
            this.PicFormatComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PicFormatComboBox.Name = "PicFormatComboBox";
            this.PicFormatComboBox.Size = new System.Drawing.Size(148, 28);
            this.PicFormatComboBox.TabIndex = 4;
            this.PicFormatComboBox.SelectedIndexChanged += new System.EventHandler(this.PicFormatComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(194, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "(Quality not available for PNG)";
            this.label1.Visible = false;
            // 
            // saveAtLabel
            // 
            this.saveAtLabel.AutoSize = true;
            this.saveAtLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveAtLabel.Location = new System.Drawing.Point(194, 178);
            this.saveAtLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.saveAtLabel.Name = "saveAtLabel";
            this.saveAtLabel.Size = new System.Drawing.Size(69, 20);
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
            "Downloads",
            "Other..."});
            this.saveAtComboBox.Location = new System.Drawing.Point(276, 174);
            this.saveAtComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveAtComboBox.Name = "saveAtComboBox";
            this.saveAtComboBox.Size = new System.Drawing.Size(133, 28);
            this.saveAtComboBox.TabIndex = 7;
            this.saveAtComboBox.SelectedIndexChanged += new System.EventHandler(this.saveAtComboBox_SelectedIndexChanged);
            // 
            // CurrentSizeLabel
            // 
            this.CurrentSizeLabel.AutoSize = true;
            this.CurrentSizeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CurrentSizeLabel.Location = new System.Drawing.Point(18, 157);
            this.CurrentSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentSizeLabel.Name = "CurrentSizeLabel";
            this.CurrentSizeLabel.Size = new System.Drawing.Size(135, 20);
            this.CurrentSizeLabel.TabIndex = 8;
            this.CurrentSizeLabel.Text = "Current Size X: Y:";
            // 
            // Screen4K_CheckBox
            // 
            this.Screen4K_CheckBox.AutoSize = true;
            this.Screen4K_CheckBox.Location = new System.Drawing.Point(22, 195);
            this.Screen4K_CheckBox.Name = "Screen4K_CheckBox";
            this.Screen4K_CheckBox.Size = new System.Drawing.Size(131, 24);
            this.Screen4K_CheckBox.TabIndex = 9;
            this.Screen4K_CheckBox.Text = "4K Res (WIP)";
            this.Screen4K_CheckBox.UseVisualStyleBackColor = true;
            this.Screen4K_CheckBox.CheckedChanged += new System.EventHandler(this.Screen4K_CheckBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(435, 231);
            this.Controls.Add(this.Screen4K_CheckBox);
            this.Controls.Add(this.CurrentSizeLabel);
            this.Controls.Add(this.saveAtComboBox);
            this.Controls.Add(this.saveAtLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PicFormatComboBox);
            this.Controls.Add(this.QualityAmountLabel);
            this.Controls.Add(this.QualityLabel);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.TakeSSButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Screenshot App";
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
        private System.Windows.Forms.Label CurrentSizeLabel;
        private System.Windows.Forms.CheckBox Screen4K_CheckBox;
    }
}

