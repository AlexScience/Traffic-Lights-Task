using TrafficLights.Services.Message;
using TrafficLights.Services.Timer;
using ConsoleColor = TrafficLights.Services.Message.ConsoleColor;

namespace TrafficLights.StateMachine
{
    public sealed class TrafficLightStateMachine : ITrafficLightStateMachine
    {
        private readonly IMessageService messageService;
        private readonly ITimerService timerService;
        private bool isFlip;

        // TODO: Добавить граничные проверки. 
        // Пример: if (messageService == null) 
        // throw new ArgumentNullException(nameof(messageService));
        public TrafficLightStateMachine(IMessageService messageService, ITimerService timerService)
        {
            this.messageService = messageService;
            this.timerService = timerService;
        }

        ~TrafficLightStateMachine() =>
            timerService.OnElapsed -= SwitchTrafficLightState;

        public void Start()
        {
            timerService.OnElapsed += SwitchTrafficLightState;
            timerService.Start();
        }

        // TODO: Разделить на методы или State's
        private void SwitchTrafficLightState()
        {
            // Don't repeat yourself! - DRY
            
            if (isFlip)
            {
                isFlip = false;
                messageService.Print($"{TrafficLightDirection.North}", ConsoleColor.Green);
                messageService.Print($"{TrafficLightDirection.South}", ConsoleColor.Green);
                messageService.Print($"{TrafficLightDirection.West}", ConsoleColor.Red);
                messageService.Print($"{TrafficLightDirection.East}", ConsoleColor.Red, true);
            }
            else
            {
                isFlip = true;
                messageService.Print($"{TrafficLightDirection.North}", ConsoleColor.Red);
                messageService.Print($"{TrafficLightDirection.South}", ConsoleColor.Red);
                messageService.Print($"{TrafficLightDirection.West}", ConsoleColor.Green);
                messageService.Print($"{TrafficLightDirection.East}", ConsoleColor.Green, true);
            }
        }
    }
}