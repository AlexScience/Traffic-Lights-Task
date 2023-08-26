using System.Diagnostics.CodeAnalysis;
using TrafficLights.Services.Input;
using TrafficLights.Services.Message;
using TrafficLights.Services.Timer;
using TrafficLights.StateMachine;

namespace TrafficLights.Boot
{
    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
    public sealed class Bootstrupper
    {
        public static void Main()
        {
            // Bind Services and Resolve.
            {
                // Initial User Input
                IInputService inputService = new InputService();
                var trafficLightTimerCooldown = inputService.GetConsoleInput();

                // State machine
                IMessageService messageService = new MessageService();
                ITimerService timerService = new TimerService(trafficLightTimerCooldown);

                // Start state machine
                ITrafficLightStateMachine stateMachine = new TrafficLightStateMachine(messageService, timerService);
                stateMachine.Start();
            }
        }
    }
}