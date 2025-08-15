using Pomodoro.Enums;

namespace Pomodoro.Services
{
    public class TimerService
    {
        private const int WorkDurationSeconds = 25 * 60;
        private const int RestDurationSeconds = 5 * 60;

        private int secondsLeft = WorkDurationSeconds;
        private bool isRunning = false;
        private TimerModes mode = TimerModes.workMode;

        public event Action<int>? OnTimeChanged;
        public event Action<string>? OnTimeEnded;

        public void Start()
        {
            isRunning = true;
        }

        public void Pause()
        {
            isRunning = false;
        }

        public void Reset()
        {
            isRunning = false;
            secondsLeft = mode == TimerModes.workMode ? WorkDurationSeconds : RestDurationSeconds;
            OnTimeChanged?.Invoke(secondsLeft);
        }

        public void Tick()
        {
            if (!isRunning) return;

            if (secondsLeft > 0)
            {
                secondsLeft--;
                OnTimeChanged?.Invoke(secondsLeft);
                return;
            }

            string userMessage = GetUserMessage();
            ChangeMode();
            OnTimeEnded?.Invoke(userMessage);
        }

        private string GetUserMessage()
        {
            string userMessage = "Congrats! Time to rest.";
            if (mode == TimerModes.restMode) userMessage = "Let's get to work!";
            return userMessage;
        }

        /// <summary>
        /// Change timer mode to opposite and 
        /// then change seconds accordingly.
        /// </summary>
        private void ChangeMode()
        {
            mode = mode == TimerModes.workMode
                ? TimerModes.restMode
                : TimerModes.workMode;

            secondsLeft = mode == TimerModes.workMode
                ? WorkDurationSeconds
                : RestDurationSeconds;

            OnTimeChanged?.Invoke(secondsLeft);
        }
    }
}
