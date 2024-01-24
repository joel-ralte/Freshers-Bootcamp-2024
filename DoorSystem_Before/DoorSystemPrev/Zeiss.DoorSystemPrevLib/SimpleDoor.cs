using System;

namespace Zeiss.DoorSystemPrevLib
{
    
    public class SimpleDoor : Door
    {
        public void Open()
        {
            this.State = DoorState.Opened;
        }
        public void Close()
        {
            this.State = DoorState.Closed;
        }
        public SmartDoor ConvertToSmartDoor(SimpleDoor simpleDoor)
        {
            SmartDoor smartDoor = new SmartDoor();
            smartDoor.State = this.State;

            return smartDoor;
        }
    }
}
