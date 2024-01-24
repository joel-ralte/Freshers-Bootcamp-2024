using System;

namespace Zeiss.DoorSystemLib
{
    public enum DoorState
    {
        Closed,
        Opened
    }
    public class SimpleDoor
    {
        public DoorState State { get; set; }
        public virtual void Open()
        {
            if(this.State == DoorState.Closed)
            {
                this.State = DoorState.Opened;
                Console.WriteLine("Door: Opened\n");
            }
        }
        public virtual void Close()
        {
            if(this.State == DoorState.Opened)
            {
                this.State = DoorState.Closed;
                Console.WriteLine("Door: Closed\n");
            }
        }
    }
}
