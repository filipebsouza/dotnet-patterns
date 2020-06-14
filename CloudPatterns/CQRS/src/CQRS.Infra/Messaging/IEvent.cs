namespace CQRS.Infra.Messaging
{
    using System;
    public interface IEvent
    {
        Guid SourceId { get; }
    }
}