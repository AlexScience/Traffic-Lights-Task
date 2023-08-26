namespace TrafficLights.Services.Timer
{
    public interface ITimerService
    {
        public event Action OnElapsed;
        public void Start();
        public void Stop();
    }
}