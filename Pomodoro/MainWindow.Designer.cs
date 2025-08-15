namespace Pomodoro
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            timer1 = new System.Windows.Forms.Timer(components);
            timerText = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            startBtn = new Button();
            stopBtn = new Button();
            resetBtn = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += Timer_Tick;
            // 
            // timerText
            // 
            timerText.Anchor = AnchorStyles.None;
            timerText.AutoSize = true;
            timerText.Location = new Point(61, 0);
            timerText.Name = "timerText";
            timerText.Size = new Size(34, 15);
            timerText.TabIndex = 3;
            timerText.Text = "25:00";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(timerText);
            flowLayoutPanel1.Controls.Add(startBtn);
            flowLayoutPanel1.Controls.Add(stopBtn);
            flowLayoutPanel1.Controls.Add(resetBtn);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(12, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(157, 115);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // startBtn
            // 
            startBtn.Location = new Point(3, 18);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(151, 23);
            startBtn.TabIndex = 0;
            startBtn.Text = "Start";
            startBtn.UseVisualStyleBackColor = true;
            startBtn.Click += StartBtn_Click;
            // 
            // stopBtn
            // 
            stopBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            stopBtn.AutoSize = true;
            stopBtn.BackColor = SystemColors.ControlLightLight;
            stopBtn.ForeColor = SystemColors.ControlText;
            stopBtn.Location = new Point(3, 47);
            stopBtn.Name = "stopBtn";
            stopBtn.Size = new Size(151, 25);
            stopBtn.TabIndex = 2;
            stopBtn.Text = "Stop";
            stopBtn.UseVisualStyleBackColor = false;
            stopBtn.Click += StopBtn_Click;
            // 
            // resetBtn
            // 
            resetBtn.BackColor = SystemColors.ControlLightLight;
            resetBtn.Location = new Point(3, 78);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(151, 23);
            resetBtn.TabIndex = 4;
            resetBtn.Text = "Reset";
            resetBtn.UseVisualStyleBackColor = false;
            resetBtn.Click += ResetBtn_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(178, 139);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainWindow";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Label timerText;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button stopBtn;
        private Button startBtn;
        private Button resetBtn;
    }
}
