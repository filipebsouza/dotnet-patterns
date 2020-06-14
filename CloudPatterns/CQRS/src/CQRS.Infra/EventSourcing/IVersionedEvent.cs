namespace CQRS.Infra.EventSourcing
{
    using CQRS.Infra.Messaging;
    public interface IVersionedEvent : IEvent
    {
        int Version { get; }
    }
}