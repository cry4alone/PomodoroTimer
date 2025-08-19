using Pomodoro.Services;

namespace Pomodoro
{
    public partial class MainWindow : Form
    {
        private TimerService _timerService;

        public MainWindow()
        {
            InitializeComponent();
            _timerService = new TimerService();

            _timerService.OnTimeChanged += UpdateLabel;
            _timerService.OnTimeEnded += WorkEnded;
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            startBtn.Enabled = false;
            _timerService.Start();
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            startBtn.Enabled = true;
            _timerService.Pause();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _timerService.Tick();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            startBtn.Enabled = true;
            _timerService.Reset();
        }

        private void UpdateLabel(int secondsLeft)
        {
            timerText.Text = $"{secondsLeft / 60}:{secondsLeft % 60:D2}";
        }

        private void WorkEnded(string messageForUser)
        {
            timer1.Stop();
            MessageBox.Show(messageForUser, "Time is up!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
