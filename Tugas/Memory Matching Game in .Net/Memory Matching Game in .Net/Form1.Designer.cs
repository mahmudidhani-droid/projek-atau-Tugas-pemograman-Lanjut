namespace Memory_Matching_Game_in_.Net
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
            components = new System.ComponentModel.Container();
            lblStatus = new Label();
            lblTimeLeft = new Label();
            btnRestart = new Button();
            GameTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(262, 127);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(136, 20);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Match or MisMatch";
            // 
            // lblTimeLeft
            // 
            lblTimeLeft.AutoSize = true;
            lblTimeLeft.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimeLeft.Location = new Point(262, 183);
            lblTimeLeft.Name = "lblTimeLeft";
            lblTimeLeft.Size = new Size(137, 28);
            lblTimeLeft.TabIndex = 1;
            lblTimeLeft.Text = "Time Left: 30";
            // 
            // btnRestart
            // 
            btnRestart.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRestart.Location = new Point(262, 43);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(136, 57);
            btnRestart.TabIndex = 2;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += RestartGameEvent;
            // 
            // GameTimer
            // 
            GameTimer.Interval = 1000;
            GameTimer.Tick += TimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 333);
            Controls.Add(btnRestart);
            Controls.Add(lblTimeLeft);
            Controls.Add(lblStatus);
            Name = "Form1";
            Text = "Memory Matching Game";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStatus;
        private Label lblTimeLeft;
        private Button btnRestart;
        private System.Windows.Forms.Timer GameTimer;
    }
}
