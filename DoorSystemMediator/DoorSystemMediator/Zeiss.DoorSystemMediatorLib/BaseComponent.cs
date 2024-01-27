using System;

namespace Zeiss.DoorSystemMediatorLib
{
    public abstract class BaseComponent
    {
        protected readonly IMediator eventAggregator;

        protected BaseComponent(IMediator eventAggregator)
        {
            this.eventAggregator = eventAggregator;
        }
    }
}
