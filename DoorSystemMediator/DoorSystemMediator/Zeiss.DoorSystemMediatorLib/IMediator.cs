using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeiss.DoorSystemMediatorLib
{
    public interface IMediator
    {
        void Subscribe<TEvent>(Action<TEvent> action);
        void Unsubscribe<TEvent>(Action<TEvent> action);
        void Publish<TEvent>(TEvent eventToPublish);
    }
}
