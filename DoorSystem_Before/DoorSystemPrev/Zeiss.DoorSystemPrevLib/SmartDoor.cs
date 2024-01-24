using System;

namespace Zeiss.DoorSystemPrevLib
{
    public class SmartDoor : SimpleDoor
    {
        public event Action OnAlert;

        private void NotifyObservers()
        {
            OnAlert.Invoke();
        }
        public void SetTimer(int seconds)
        {
            Console.WriteLine($"Timer set for {seconds} seconds\n");

            Open();
            NotifyObservers();
        }
    }
}
