namespace TrafficLights.Services.Message
{
    public sealed class MessageService : IMessageService
    {
        public void Print(string message, ConsoleColor color, bool canSpace = false)
        {
            Console.ForegroundColor = GetConsoleColor(color);

            Console.WriteLine(message);

            Console.ResetColor();

            if (canSpace)
                Console.WriteLine();

            System.ConsoleColor GetConsoleColor(ConsoleColor consoleColor)
            {
                return consoleColor switch
                {
                    ConsoleColor.Red => System.ConsoleColor.Red,
                    ConsoleColor.Green => System.ConsoleColor.Green,
                    _ => System.ConsoleColor.White
                };
            }
        }
    }
}