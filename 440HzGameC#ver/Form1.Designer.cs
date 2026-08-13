namespace _440HzGameC_ver
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblRetry = new Label();
            lblResult = new Label();
            btnPlay = new Button();
            btnEnter = new Button();
            btnRetry = new Button();
            btnExit = new Button();
            trackBar1 = new TrackBar();
            lblHz = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // lblRetry
            // 
            lblRetry.AutoSize = true;
            lblRetry.Font = new Font("Yu Gothic UI", 13F);
            lblRetry.Location = new Point(430, 30);
            lblRetry.Name = "lblRetry";
            lblRetry.Size = new Size(89, 25);
            lblRetry.TabIndex = 0;
            lblRetry.Text = "Retries : 0";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Yu Gothic UI", 70F);
            lblResult.Location = new Point(179, 100);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(236, 125);
            lblResult.TabIndex = 2;
            lblResult.Text = "WIN";
            lblResult.Visible = false;
            // 
            // btnPlay
            // 
            btnPlay.Font = new Font("Yu Gothic UI", 10F);
            btnPlay.Location = new Point(30, 30);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(60, 50);
            btnPlay.TabIndex = 3;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnEnter
            // 
            btnEnter.Font = new Font("Yu Gothic UI", 10F);
            btnEnter.Location = new Point(110, 30);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(60, 50);
            btnEnter.TabIndex = 4;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // btnRetry
            // 
            btnRetry.Font = new Font("Yu Gothic UI", 10F);
            btnRetry.Location = new Point(30, 30);
            btnRetry.Name = "btnRetry";
            btnRetry.Size = new Size(60, 50);
            btnRetry.TabIndex = 5;
            btnRetry.Text = "Retry";
            btnRetry.UseVisualStyleBackColor = true;
            btnRetry.Visible = false;
            btnRetry.Click += btnRetry_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Yu Gothic UI", 10F);
            btnExit.Location = new Point(110, 30);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(60, 50);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Visible = false;
            btnExit.Click += btnExit_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(100, 180);
            trackBar1.Maximum = 480;
            trackBar1.Minimum = 380;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(400, 45);
            trackBar1.TabIndex = 7;
            trackBar1.TickStyle = TickStyle.None;
            trackBar1.Value = 430;
            // 
            // lblHz
            // 
            lblHz.AutoSize = true;
            lblHz.Font = new Font("Yu Gothic UI", 20F);
            lblHz.Location = new Point(255, 228);
            lblHz.Name = "lblHz";
            lblHz.Size = new Size(93, 37);
            lblHz.TabIndex = 8;
            lblHz.Text = "440Hz";
            lblHz.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(lblHz);
            Controls.Add(trackBar1);
            Controls.Add(btnExit);
            Controls.Add(btnRetry);
            Controls.Add(btnEnter);
            Controls.Add(btnPlay);
            Controls.Add(lblResult);
            Controls.Add(lblRetry);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "otoawase";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRetry;
        private Label lblResult;
        private Button btnPlay;
        private Button btnEnter;
        private Button btnRetry;
        private Button btnExit;
        private TrackBar trackBar1;
        private Label lblHz;
    }
}
