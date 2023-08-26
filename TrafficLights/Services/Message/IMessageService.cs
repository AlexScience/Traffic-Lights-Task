namespace TrafficLights.Services.Message
{
    public interface IMessageService
    {
        public void Print(string message, ConsoleColor color, bool canSpace = false);
    }
}