using System;
using System.Threading;

namespace Zeiss.DoorSystemMediatorLib
{
    public class Timer
    {
        public int Duration { get; private set; }

        public Timer(int TimerLimit)
        {
            Duration = TimerLimit;
        }
        public void StartCountdown(Action<int> callback)
        {
            for (int i = Duration; i >= 0; i--)
            {
                Console.WriteLine($"Countdown: {i} seconds remaining");
                Thread.Sleep(1000);
            }
            callback?.Invoke(0);
        }
    }
}
