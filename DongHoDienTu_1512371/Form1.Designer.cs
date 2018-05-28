namespace DongHoDienTu_1512371
{
    partial class Form1
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
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.ResumeButton = new System.Windows.Forms.Button();
            this.SetButton = new System.Windows.Forms.Button();
            this.SecondsUpDown = new System.Windows.Forms.NumericUpDown();
            this.MinutesUpDown = new System.Windows.Forms.NumericUpDown();
            this.dongHoDienTuUserControl1 = new DongHoDienTu_1512371.DongHoDienTuUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.SecondsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(168, 143);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(168, 172);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 2;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Location = new System.Drawing.Point(290, 172);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(75, 23);
            this.PauseButton.TabIndex = 3;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // ResumeButton
            // 
            this.ResumeButton.Location = new System.Drawing.Point(290, 143);
            this.ResumeButton.Name = "ResumeButton";
            this.ResumeButton.Size = new System.Drawing.Size(75, 23);
            this.ResumeButton.TabIndex = 4;
            this.ResumeButton.Text = "Resume";
            this.ResumeButton.UseVisualStyleBackColor = true;
            this.ResumeButton.Click += new System.EventHandler(this.ResumeButton_Click);
            // 
            // SetButton
            // 
            this.SetButton.Location = new System.Drawing.Point(48, 143);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(75, 23);
            this.SetButton.TabIndex = 7;
            this.SetButton.Text = "Set Timer";
            this.SetButton.UseVisualStyleBackColor = true;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // SecondsUpDown
            // 
            this.SecondsUpDown.Location = new System.Drawing.Point(86, 172);
            this.SecondsUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.SecondsUpDown.Name = "SecondsUpDown";
            this.SecondsUpDown.Size = new System.Drawing.Size(37, 20);
            this.SecondsUpDown.TabIndex = 8;
            // 
            // MinutesUpDown
            // 
            this.MinutesUpDown.Location = new System.Drawing.Point(48, 172);
            this.MinutesUpDown.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.MinutesUpDown.Name = "MinutesUpDown";
            this.MinutesUpDown.Size = new System.Drawing.Size(40, 20);
            this.MinutesUpDown.TabIndex = 9;
            // 
            // dongHoDienTuUserControl1
            // 
            this.dongHoDienTuUserControl1.Location = new System.Drawing.Point(-2, 26);
            this.dongHoDienTuUserControl1.Name = "dongHoDienTuUserControl1";
            this.dongHoDienTuUserControl1.Size = new System.Drawing.Size(413, 101);
            this.dongHoDienTuUserControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 222);
            this.Controls.Add(this.MinutesUpDown);
            this.Controls.Add(this.SecondsUpDown);
            this.Controls.Add(this.SetButton);
            this.Controls.Add(this.ResumeButton);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.dongHoDienTuUserControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.SecondsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DongHoDienTuUserControl dongHoDienTuUserControl1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button ResumeButton;
        private System.Windows.Forms.Button SetButton;
        private System.Windows.Forms.NumericUpDown SecondsUpDown;
        private System.Windows.Forms.NumericUpDown MinutesUpDown;
    }
}

