namespace ColorMixing
{
    partial class PlayTonBoy
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
            this.components = new System.ComponentModel.Container();
            this.platonbox1 = new System.Windows.Forms.PictureBox();
            this.platonbox3 = new System.Windows.Forms.PictureBox();
            this.platonbox2 = new System.Windows.Forms.PictureBox();
            this.RandomRed = new System.Windows.Forms.Button();
            this.RandomGreen = new System.Windows.Forms.Button();
            this.RandomBlue = new System.Windows.Forms.Button();
            this.RandomMix = new System.Windows.Forms.Button();
            this.RedSlider = new System.Windows.Forms.TrackBar();
            this.GreenSlider = new System.Windows.Forms.TrackBar();
            this.BlueSlider = new System.Windows.Forms.TrackBar();
            this.ResetColors = new System.Windows.Forms.Button();
            this.timerred = new System.Windows.Forms.Timer(this.components);
            this.RedTimerStart = new System.Windows.Forms.Button();
            this.timergreen = new System.Windows.Forms.Timer(this.components);
            this.timerblue = new System.Windows.Forms.Timer(this.components);
            this.GreenTimerStart = new System.Windows.Forms.Button();
            this.BlueTimerStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.platonbox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platonbox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platonbox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // platonbox1
            // 
            this.platonbox1.Location = new System.Drawing.Point(12, 3);
            this.platonbox1.Name = "platonbox1";
            this.platonbox1.Size = new System.Drawing.Size(240, 240);
            this.platonbox1.TabIndex = 0;
            this.platonbox1.TabStop = false;
            // 
            // platonbox3
            // 
            this.platonbox3.Location = new System.Drawing.Point(548, 3);
            this.platonbox3.Name = "platonbox3";
            this.platonbox3.Size = new System.Drawing.Size(240, 240);
            this.platonbox3.TabIndex = 1;
            this.platonbox3.TabStop = false;
            // 
            // platonbox2
            // 
            this.platonbox2.Location = new System.Drawing.Point(278, 3);
            this.platonbox2.Name = "platonbox2";
            this.platonbox2.Size = new System.Drawing.Size(240, 240);
            this.platonbox2.TabIndex = 2;
            this.platonbox2.TabStop = false;
            // 
            // RandomRed
            // 
            this.RandomRed.Location = new System.Drawing.Point(12, 338);
            this.RandomRed.Name = "RandomRed";
            this.RandomRed.Size = new System.Drawing.Size(240, 76);
            this.RandomRed.TabIndex = 3;
            this.RandomRed.Text = "Random Red";
            this.RandomRed.UseVisualStyleBackColor = true;
            this.RandomRed.Click += new System.EventHandler(this.RandomRed_Click);
            // 
            // RandomGreen
            // 
            this.RandomGreen.Location = new System.Drawing.Point(278, 338);
            this.RandomGreen.Name = "RandomGreen";
            this.RandomGreen.Size = new System.Drawing.Size(240, 76);
            this.RandomGreen.TabIndex = 4;
            this.RandomGreen.Text = "Random Green";
            this.RandomGreen.UseVisualStyleBackColor = true;
            this.RandomGreen.Click += new System.EventHandler(this.RandomGreen_Click);
            // 
            // RandomBlue
            // 
            this.RandomBlue.Location = new System.Drawing.Point(548, 338);
            this.RandomBlue.Name = "RandomBlue";
            this.RandomBlue.Size = new System.Drawing.Size(240, 76);
            this.RandomBlue.TabIndex = 5;
            this.RandomBlue.Text = "Random Blue";
            this.RandomBlue.UseVisualStyleBackColor = true;
            this.RandomBlue.Click += new System.EventHandler(this.RandomBlue_Click);
            // 
            // RandomMix
            // 
            this.RandomMix.Location = new System.Drawing.Point(12, 420);
            this.RandomMix.Name = "RandomMix";
            this.RandomMix.Size = new System.Drawing.Size(776, 76);
            this.RandomMix.TabIndex = 6;
            this.RandomMix.Text = "Random mix";
            this.RandomMix.UseVisualStyleBackColor = true;
            this.RandomMix.Click += new System.EventHandler(this.RandomMix_Click);
            // 
            // RedSlider
            // 
            this.RedSlider.Location = new System.Drawing.Point(12, 249);
            this.RedSlider.Maximum = 255;
            this.RedSlider.Name = "RedSlider";
            this.RedSlider.Size = new System.Drawing.Size(240, 45);
            this.RedSlider.TabIndex = 7;
            this.RedSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.RedSlider.Scroll += new System.EventHandler(this.RedSlider_Scroll);
            // 
            // GreenSlider
            // 
            this.GreenSlider.Location = new System.Drawing.Point(278, 249);
            this.GreenSlider.Maximum = 255;
            this.GreenSlider.Name = "GreenSlider";
            this.GreenSlider.Size = new System.Drawing.Size(240, 45);
            this.GreenSlider.TabIndex = 8;
            this.GreenSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.GreenSlider.Scroll += new System.EventHandler(this.GreenSlider_Scroll);
            // 
            // BlueSlider
            // 
            this.BlueSlider.Location = new System.Drawing.Point(548, 249);
            this.BlueSlider.Maximum = 255;
            this.BlueSlider.Name = "BlueSlider";
            this.BlueSlider.Size = new System.Drawing.Size(240, 45);
            this.BlueSlider.TabIndex = 9;
            this.BlueSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.BlueSlider.Scroll += new System.EventHandler(this.BlueSlider_Scroll);
            // 
            // ResetColors
            // 
            this.ResetColors.Location = new System.Drawing.Point(12, 502);
            this.ResetColors.Name = "ResetColors";
            this.ResetColors.Size = new System.Drawing.Size(776, 76);
            this.ResetColors.TabIndex = 10;
            this.ResetColors.Text = "Reset Colors";
            this.ResetColors.UseVisualStyleBackColor = true;
            this.ResetColors.Click += new System.EventHandler(this.ResetColors_Click);
            // 
            // timerred
            // 
            this.timerred.Tick += new System.EventHandler(this.timerred_Tick);
            // 
            // RedTimerStart
            // 
            this.RedTimerStart.Location = new System.Drawing.Point(13, 301);
            this.RedTimerStart.Name = "RedTimerStart";
            this.RedTimerStart.Size = new System.Drawing.Size(239, 31);
            this.RedTimerStart.TabIndex = 11;
            this.RedTimerStart.Text = "ReD PaRtY";
            this.RedTimerStart.UseVisualStyleBackColor = true;
            this.RedTimerStart.Click += new System.EventHandler(this.RedTimerStart_Click);
            // 
            // timergreen
            // 
            this.timergreen.Tick += new System.EventHandler(this.timergreen_Tick);
            // 
            // timerblue
            // 
            this.timerblue.Tick += new System.EventHandler(this.timerblue_Tick);
            // 
            // GreenTimerStart
            // 
            this.GreenTimerStart.Location = new System.Drawing.Point(279, 301);
            this.GreenTimerStart.Name = "GreenTimerStart";
            this.GreenTimerStart.Size = new System.Drawing.Size(239, 31);
            this.GreenTimerStart.TabIndex = 12;
            this.GreenTimerStart.Text = "GrEeN PaRtY";
            this.GreenTimerStart.UseVisualStyleBackColor = true;
            this.GreenTimerStart.Click += new System.EventHandler(this.GreenTimerStart_Click);
            // 
            // BlueTimerStart
            // 
            this.BlueTimerStart.Location = new System.Drawing.Point(549, 300);
            this.BlueTimerStart.Name = "BlueTimerStart";
            this.BlueTimerStart.Size = new System.Drawing.Size(239, 31);
            this.BlueTimerStart.TabIndex = 13;
            this.BlueTimerStart.Text = "BlUe PaRtY";
            this.BlueTimerStart.UseVisualStyleBackColor = true;
            this.BlueTimerStart.Click += new System.EventHandler(this.BlueTimerStart_Click);
            // 
            // PlayTonBoy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 590);
            this.Controls.Add(this.BlueTimerStart);
            this.Controls.Add(this.GreenTimerStart);
            this.Controls.Add(this.RedTimerStart);
            this.Controls.Add(this.ResetColors);
            this.Controls.Add(this.BlueSlider);
            this.Controls.Add(this.GreenSlider);
            this.Controls.Add(this.RedSlider);
            this.Controls.Add(this.RandomMix);
            this.Controls.Add(this.RandomBlue);
            this.Controls.Add(this.RandomGreen);
            this.Controls.Add(this.RandomRed);
            this.Controls.Add(this.platonbox2);
            this.Controls.Add(this.platonbox3);
            this.Controls.Add(this.platonbox1);
            this.Name = "PlayTonBoy";
            this.Text = "PlayTonBoy";
            ((System.ComponentModel.ISupportInitialize)(this.platonbox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platonbox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platonbox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox platonbox1;
        private System.Windows.Forms.PictureBox platonbox3;
        private System.Windows.Forms.PictureBox platonbox2;
        private System.Windows.Forms.Button RandomRed;
        private System.Windows.Forms.Button RandomGreen;
        private System.Windows.Forms.Button RandomBlue;
        private System.Windows.Forms.Button RandomMix;
        private System.Windows.Forms.TrackBar RedSlider;
        private System.Windows.Forms.TrackBar GreenSlider;
        private System.Windows.Forms.TrackBar BlueSlider;
        private System.Windows.Forms.Button ResetColors;
        private System.Windows.Forms.Timer timerred;
        private System.Windows.Forms.Button RedTimerStart;
        private System.Windows.Forms.Timer timergreen;
        private System.Windows.Forms.Timer timerblue;
        private System.Windows.Forms.Button GreenTimerStart;
        private System.Windows.Forms.Button BlueTimerStart;
    }
}

