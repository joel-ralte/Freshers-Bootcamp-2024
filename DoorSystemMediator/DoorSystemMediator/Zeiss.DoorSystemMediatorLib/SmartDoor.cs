using System;

namespace Zeiss.DoorSystemMediatorLib
{
    public class SmartDoor : SimpleDoor
    {
        public int TimerLimit { get; set; }
        public Timer timerManager;
        public SmartDoor(IMediator eventAggregator) : base(eventAggregator) { }

        public override void Open()
        {
            base.Open();
            SetTimer(TimerLimit);
        }

        public override void Close()
        {
            base.Close();
        }

        private void SetTimer(int seconds)
        {
            Console.WriteLine($"Timer set for {seconds} seconds\n");

            timerManager = new Timer(seconds);
            timerManager.StartCountdown((remainingSeconds) =>
            {
                if (remainingSeconds == 0)
                {
                    eventAggregator.Publish(new DoorStateChangedEvent(this.State));
                }
            });
        }

        public void HandleDoorStateChanged(DoorStateChangedEvent doorStateChangedEvent)
        {
            if (doorStateChangedEvent.NewState == DoorState.Closed)
            {
                Close();
            }
        }
    }
}
