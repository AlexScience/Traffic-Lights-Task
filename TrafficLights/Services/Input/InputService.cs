namespace TrafficLights.Services.Input
{
    public sealed class InputService : IInputService
    {
        public int GetConsoleInput()
        {
            // TODO: Обработать исключения и убрать приветсвие.

            Console.WriteLine("Введите длительность работы таймера светофора: ");

            return int.Parse(Console.ReadLine() ?? "5"); // TODO: Magic number anti pattern "5"
        }
    }
}