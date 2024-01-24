using System;
using System.Reflection;
using Zeiss.DoorSystemPrevLib;

namespace Zeiss.DoorSystemPrevLib
{
    public class Operator
    {
        public Door door;

        public Operator(Door door)
        {
            this.door = door;
        }
        public void OpenDoor()
        {
            door.State = DoorState.Opened;
        }
        public void CloseDoor()
        {
            door.State = DoorState.Closed;
        }
    }
}
