using System;

namespace Zeiss.DoorSystemMediatorLib
{
    public class Buzzer : BaseComponent
    {
        public Buzzer(IMediator eventAggregator) : base(eventAggregator) { }

        public void HandleDoorStateChanged(DoorStateChangedEvent doorStateChangedEvent)
        {
            if (doorStateChangedEvent.NewState == DoorState.Opened)
            {
                Console.WriteLine($"Buzzer Alerted: Door opened beyond threshold");
            }
        }
    }
}