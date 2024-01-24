using System;
using System.Threading;
using System.Threading.Tasks;

namespace Zeiss.DoorSystemLib
{
    public class TimerManager
    {
        public int Duration { get; private set; }

        public TimerManager(int TimerLimit)
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
