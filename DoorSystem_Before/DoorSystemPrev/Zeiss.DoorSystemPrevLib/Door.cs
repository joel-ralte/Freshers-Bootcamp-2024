using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeiss.DoorSystemPrevLib
{
    public enum DoorState
    {
        Closed,
        Opened
    }
    public class Door
    {
        public DoorState State;
        public Door() { this.State = DoorState.Closed; }
    }
}
