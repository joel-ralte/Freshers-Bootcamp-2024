using System;

namespace Zeiss.DoorSystemLib
{
    public class SmartDoor : SimpleDoor
    {
        public int TimerLimit { get; set; }
        public event Action OnAlert;
        private TimerManager Timer;
        
        public override void Open()
        {
            base.Open();
            SetTimer(TimerLimit);
        }
        public override void Close()
        {
            base.Close();
        }
        private void NotifyObservers()
        {
            if (OnAlert != null)
            {
                OnAlert.Invoke();
            }
        }
        public void SetTimer(int seconds)
        {
            Console.WriteLine($"Timer set for {seconds} seconds\n");

            Timer = new TimerManager(seconds);
            Timer.StartCountdown((remainingSeconds) =>
            {
                if (remainingSeconds == 0)
                {
                    NotifyObservers();
                }
            });
        }
    }
}
