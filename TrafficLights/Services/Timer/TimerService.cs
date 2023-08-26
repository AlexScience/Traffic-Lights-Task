namespace TrafficLights.Services.Timer
{
    public sealed class TimerService : ITimerService
    {
        public event Action? OnElapsed;

        private readonly TimeSpan interval;
        private bool isRunning;

        public TimerService(int seconds)
        {
            interval = TimeSpan.FromSeconds(seconds);
            isRunning = false;
        }

        public void Start()
        {
            isRunning = true;

            while (isRunning)
            {
                OnElapsed?.Invoke();

                Thread.Sleep(interval);
            }
        }

        public void Stop() =>
            isRunning = false;
    }
}